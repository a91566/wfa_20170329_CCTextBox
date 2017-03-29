using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace wfa_20170329_CCTextBox
{
	public partial class CCTextBox : TextBox, ICCControlGetValue
	{
		public CCTextBox()
		{
			InitializeComponent();
		}

		public CCTextBox(IContainer container)
		{
			container.Add(this);
			InitializeComponent();
		}

		[Description("格式化")]
		public string ccFormat { get; set; }

		public T GetValue<T>()
		{
			if (ccFormat == "0.01d")
			{
				Text = Convert.ToDouble(Text).ToString("0.00");
			}
			return (T)Convert.ChangeType(Text, typeof(T));
		}

		
	}
}
