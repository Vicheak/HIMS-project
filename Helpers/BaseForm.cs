using HIMS_Project.Helpers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class BaseForm : Form
{
    public BaseForm()
    {
        this.Load += BaseForm_Load;
    }

    private void BaseForm_Load(object sender, EventArgs e)
    {
        ApplyFonts(this);
        AttachTextChangedHandlers(this);
    }

    protected void ApplyFonts(Control control)
    {
        foreach (Control childControl in control.Controls)
        {
            ApplyFontToControl(childControl);

            // Handle ToolStrip and similar controls
            if (childControl is ToolStrip toolStrip)
            {
                foreach (ToolStripItem item in toolStrip.Items)
                {
                    ApplyFontToToolStripItem(item);
                }
            }
            else if (childControl is DataGridView dataGridView)
            {
                ApplyFontToDataGridView(dataGridView);
            }

            // Recursively apply fonts to child controls
            ApplyFonts(childControl);
        }
    }

    private void ApplyFontToControl(Control control)
    {
        var fontProperty = control.GetType().GetProperty("Font");
        if (fontProperty != null && fontProperty.PropertyType == typeof(Font))
        {
            if (IsKhmerText(control.Text))
            {
                fontProperty.SetValue(control, FontManager.GetKhmerFont(control.Font.Size, control.Font.Style));
            }
            else
            {
                fontProperty.SetValue(control, FontManager.GetEnglishFont(control.Font.Size, control.Font.Style));
            }
        }
    }

    private void ApplyFontToToolStripItem(ToolStripItem item)
    {
        if (IsKhmerText(item.Text))
        {
            item.Font = FontManager.GetKhmerFont(item.Font.Size, item.Font.Style);
        }
        else
        {
            item.Font = FontManager.GetEnglishFont(item.Font.Size, item.Font.Style);
        }
    }

    private void ApplyFontToDataGridView(DataGridView dataGridView)
    {
        // Create the fonts once to use for both header and cells
        var englishFont = FontManager.GetEnglishFont(11, dataGridView.Font.Style);
        var khmerFont = FontManager.GetKhmerFont(11, dataGridView.Font.Style);

        // Apply font to column headers default cell style
        dataGridView.ColumnHeadersDefaultCellStyle.Font = englishFont;

        // Apply font to the columns and cells after data binding is complete
        dataGridView.DataBindingComplete += (sender, e) =>
        {
            // Apply font to column headers
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderCell.Style.Font = IsKhmerText(column.HeaderText) ? khmerFont : englishFont;
            }

            // Apply font to each cell in each row
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        cell.Style.Font = IsKhmerText(cell.Value.ToString()) ? khmerFont : englishFont;
                    }
                }
            }
        };

        // Apply font to default cell style for new rows
        dataGridView.DefaultCellStyle.Font = englishFont;
    }



    protected void AttachTextChangedHandlers(Control control)
    {
        foreach (Control childControl in control.Controls)
        {
            if (childControl is TextBoxBase || childControl is ComboBox)
            {
                childControl.TextChanged += (sender, e) => ApplyFontToControl((Control)sender);
            }
            else if (childControl is DataGridView dataGridView)
            {
                dataGridView.CellValueChanged += (sender, e) =>
                {
                    var cell = dataGridView[e.ColumnIndex, e.RowIndex];
                    if (cell.Value != null)
                    {
                        cell.Style.Font = IsKhmerText(cell.Value.ToString())
                            ? FontManager.GetKhmerFont(11, dataGridView.Font.Style)
                            : FontManager.GetEnglishFont(11, dataGridView.Font.Style);
                    }
                };
            }

            // Recursively attach text changed handlers to child controls
            AttachTextChangedHandlers(childControl);
        }
    }

    private bool IsKhmerText(string text)
    {
        return text.Any(c => c >= '\u1780' && c <= '\u17FF');
    }
}