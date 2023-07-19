using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KartRider.IO;
using System.IO;
using System.Runtime.CompilerServices;

namespace KartRider
{
    public partial class KartBoundingBox : Form
    {
		public static string FileName = "model.1s";

		public static bool KartBoundingBoxRoad = true;
		public static bool KartBoundingBoxSave = false;
		public static bool KartBoundingBoxReset = true;

		public static float min_x;
		public static float min_y;
		public static float min_z;
		public static float max_x;
		public static float max_y;
		public static float max_z;

		public KartBoundingBox()
        {
            InitializeComponent();
        }

		public static void Start()
		{
			if (File.Exists(KartBoundingBox.FileName))
			{
				InPacket i = new InPacket(File.ReadAllBytes(KartBoundingBox.FileName));
				i.Position = i.Length - 16;
				InPacket position = i;
				position.Position = position.Position - 24;
				int lp = i.Position;
				if (KartBoundingBox.KartBoundingBoxRoad)
				{
					float min_x = i.ReadFloat();
					float min_y = i.ReadFloat();
					float min_z = i.ReadFloat();
					float max_x = i.ReadFloat();
					float max_y = i.ReadFloat();
					float max_z = i.ReadFloat();

					if (KartBoundingBox.KartBoundingBoxReset)
					{
						KartBoundingBox.min_x = min_x;
						KartBoundingBox.min_y = min_y;
						KartBoundingBox.min_z = min_z;
						KartBoundingBox.max_x = max_x;
						KartBoundingBox.max_y = max_y;
						KartBoundingBox.max_z = max_z;
						KartBoundingBox.KartBoundingBoxReset = false;
					}

					Program.KartBoundingBoxForm.tx_min_x.Text = string.Concat(min_x);
					Program.KartBoundingBoxForm.tx_min_y.Text = string.Concat(min_y);
					Program.KartBoundingBoxForm.tx_min_z.Text = string.Concat(min_z);
					Program.KartBoundingBoxForm.tx_max_x.Text = string.Concat(max_x);
					Program.KartBoundingBoxForm.tx_max_y.Text = string.Concat(max_y);
					Program.KartBoundingBoxForm.tx_max_z.Text = string.Concat(max_z);
				}
				if (KartBoundingBox.KartBoundingBoxSave)
				{
					DateTime now = DateTime.Now;
					File.Copy(KartBoundingBox.FileName, string.Concat("model-", now.ToString("yyyyMMddHHmmss"), ".1s"));
					i.Position = 0;
					OutPacket oPacket = new OutPacket(64);
					oPacket.WriteBytes(i.ReadBytes(lp));
					i.Skip(24);
					oPacket.WriteFloat(float.Parse(Program.KartBoundingBoxForm.tx_min_x.Text));
					oPacket.WriteFloat(float.Parse(Program.KartBoundingBoxForm.tx_min_y.Text));
					oPacket.WriteFloat(float.Parse(Program.KartBoundingBoxForm.tx_min_z.Text));
					oPacket.WriteFloat(float.Parse(Program.KartBoundingBoxForm.tx_max_x.Text));
					oPacket.WriteFloat(float.Parse(Program.KartBoundingBoxForm.tx_max_y.Text));
					oPacket.WriteFloat(float.Parse(Program.KartBoundingBoxForm.tx_max_z.Text));
					oPacket.WriteBytes(i.ReadBytes(16));
					File.WriteAllBytes(KartBoundingBox.FileName, oPacket.ToArray());
					MessageBox.Show("파일이 생성되었습니다.");
				}
			}
            else
            {
				MessageBox.Show(KartBoundingBox.FileName + " 파일을 찾을 수 없습니다!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(1);
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
        {
			KartBoundingBox.KartBoundingBoxRoad = false;
			KartBoundingBox.KartBoundingBoxSave = true;
			KartBoundingBox.Start();
		}

        private void KartBoundingBoxForm_Load(object sender, EventArgs e)
        {
			KartBoundingBox.Start();
		}

        private void btn_Reset_Click(object sender, EventArgs e)
        {
			Program.KartBoundingBoxForm.tx_min_x.Text = string.Concat(KartBoundingBox.min_x);
			Program.KartBoundingBoxForm.tx_min_y.Text = string.Concat(KartBoundingBox.min_y);
			Program.KartBoundingBoxForm.tx_min_z.Text = string.Concat(KartBoundingBox.min_z);
			Program.KartBoundingBoxForm.tx_max_x.Text = string.Concat(KartBoundingBox.max_x);
			Program.KartBoundingBoxForm.tx_max_y.Text = string.Concat(KartBoundingBox.max_y);
			Program.KartBoundingBoxForm.tx_max_z.Text = string.Concat(KartBoundingBox.max_z);
			MessageBox.Show("수치값이 초기화되었습니다.");
		}
    }
}
