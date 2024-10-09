using System.Runtime.InteropServices;

namespace GOOOOOOOOOOOOOOL {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			hHook = SetWindowsHookEx(WH_KEYBOARD_LL, HkProc, IntPtr.Zero, 0);
		}

		private void ChanceBar_Scroll(object sender, EventArgs e) {
			ChanceLabel.Text = $"Шанс: {ChanceBar.Value}%";
			ChanceLabel.ForeColor = ChanceBar.Value > 50 ? Color.Firebrick : Color.FromKnownColor(KnownColor.ControlText);
		}

		private void EnableBox_CheckedChanged(object sender, EventArgs e) {
			ChanceLabel.Enabled = EnableBox.Checked;
		}

		[DllImport("user32")]
		static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);
		[DllImport("user32")]
		static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
		[DllImport("user32")]
static extern bool UnhookWindowsHookEx(IntPtr hhk);
		delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
		const int WH_KEYBOARD_LL = 13;
		IntPtr hHook = IntPtr.Zero;
		~Form1() {
			UnhookWindowsHookEx(hHook);
		}
		IntPtr HkProc(int nCode, IntPtr wParam, IntPtr lParam) {
			if (nCode >= 0 && wParam == (IntPtr)256) // WM_KEYDOWN
			{
				var vkCode = (Keys)Marshal.ReadInt32(lParam);
				if (EnableBox.Checked) {
					Random rand = new Random();
					if (rand.Next(1, 100 / ChanceBar.Value + 1) == 1) {
						string GOOOOOOOOOOL = $"Г{new string('О', rand.Next(3, 16))}Л";
						try {
							SendKeys.Send(GOOOOOOOOOOL);
						} catch {}
					}
				}
			}
			return CallNextHookEx(hHook, nCode, wParam, lParam);
		}
	}
}
