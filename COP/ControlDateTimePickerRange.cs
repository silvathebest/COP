using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP
{
    public partial class ControlDateTimePickerRange : UserControl
    {
        protected bool _isLoaded = false;

        [Category("Спецификация")]
        [Description("Максимальная дата")]
        public DateTime? MaxDate { get; set; } = null;

        [Category("Спецификация")]
        [Description("Минимальная дата")]
        public DateTime? MinDate { get; set; } = null;

        [Category("Спецификация")]
        [Description("Значение")]
        public DateTime? Value
        {
            get
            {
                DateTime? minDate;
                DateTime? nullable;
                bool hasValue;
                if (!_isLoaded)
                {
                    minDate = null;
                    nullable = minDate;
                }
                else
                {
                    minDate = MinDate;
                    if (!minDate.HasValue)
                    {
                        hasValue = true;
                    }
                    else
                    {
                        minDate = MaxDate;
                        hasValue = !minDate.HasValue;
                    }
                    if (hasValue)
                    {
                        throw new ArgumentNullException();
                    }
                    DateTime value = dateTimePicker.Value;
                    minDate = MinDate;
                    if (minDate.HasValue && value > minDate.GetValueOrDefault())
                    {
                        value = dateTimePicker.Value;
                        minDate = MaxDate;
                        if (!minDate.HasValue || value >= minDate.GetValueOrDefault())
                        {
                            throw new ArgumentException();
                        }
                        nullable = new DateTime?(dateTimePicker.Value);
                        return nullable;
                    }
                    throw new ArgumentException();
                }
                return nullable;
            }
            set
            {
                bool hasValue;
                bool flag;
                DateTime? minDate = MinDate;
                if (minDate.HasValue)
                {
                    minDate = MaxDate;
                    if (!minDate.HasValue)
                    {
                        goto Label1;
                    }
                    hasValue = false;
                    goto Label0;
                }
            Label1:
                hasValue = value.HasValue;
            Label0:
                if (hasValue)
                {
                    minDate = value;
                    DateTime? nullable = MinDate;
                    if (!minDate.HasValue | !nullable.HasValue || minDate.GetValueOrDefault() <= nullable.GetValueOrDefault())
                    {
                        flag = false;
                    }
                    else
                    {
                        nullable = value;
                        minDate = MaxDate;
                        flag = nullable.HasValue & minDate.HasValue && nullable.GetValueOrDefault() < minDate.GetValueOrDefault();
                    }
                    if (flag)
                    {
                        dateTimePicker.Value = value.Value;
                    }
                }
            }
        }
        public ControlDateTimePickerRange()
        {
            InitializeComponent();
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _isLoaded = true;
        }
    }
}
