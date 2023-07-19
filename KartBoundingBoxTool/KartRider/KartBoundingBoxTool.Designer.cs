namespace KartRider
{
    partial class KartBoundingBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_MinX = new System.Windows.Forms.Label();
            this.label_MinY = new System.Windows.Forms.Label();
            this.label_MinZ = new System.Windows.Forms.Label();
            this.label_MaxX = new System.Windows.Forms.Label();
            this.label_MaxY = new System.Windows.Forms.Label();
            this.label_MaxZ = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tx_min_x = new System.Windows.Forms.TextBox();
            this.tx_min_y = new System.Windows.Forms.TextBox();
            this.tx_min_z = new System.Windows.Forms.TextBox();
            this.tx_max_x = new System.Windows.Forms.TextBox();
            this.tx_max_y = new System.Windows.Forms.TextBox();
            this.tx_max_z = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MinX
            // 
            this.label_MinX.AutoSize = true;
            this.label_MinX.Location = new System.Drawing.Point(12, 24);
            this.label_MinX.Name = "label_MinX";
            this.label_MinX.Size = new System.Drawing.Size(38, 12);
            this.label_MinX.TabIndex = 0;
            this.label_MinX.Text = "MinX:";
            // 
            // label_MinY
            // 
            this.label_MinY.AutoSize = true;
            this.label_MinY.Location = new System.Drawing.Point(170, 24);
            this.label_MinY.Name = "label_MinY";
            this.label_MinY.Size = new System.Drawing.Size(38, 12);
            this.label_MinY.TabIndex = 1;
            this.label_MinY.Text = "MinY:";
            // 
            // label_MinZ
            // 
            this.label_MinZ.AutoSize = true;
            this.label_MinZ.Location = new System.Drawing.Point(334, 24);
            this.label_MinZ.Name = "label_MinZ";
            this.label_MinZ.Size = new System.Drawing.Size(38, 12);
            this.label_MinZ.TabIndex = 2;
            this.label_MinZ.Text = "MinZ:";
            // 
            // label_MaxX
            // 
            this.label_MaxX.AutoSize = true;
            this.label_MaxX.Location = new System.Drawing.Point(12, 106);
            this.label_MaxX.Name = "label_MaxX";
            this.label_MaxX.Size = new System.Drawing.Size(42, 12);
            this.label_MaxX.TabIndex = 3;
            this.label_MaxX.Text = "MaxX:";
            // 
            // label_MaxY
            // 
            this.label_MaxY.AutoSize = true;
            this.label_MaxY.Location = new System.Drawing.Point(170, 106);
            this.label_MaxY.Name = "label_MaxY";
            this.label_MaxY.Size = new System.Drawing.Size(42, 12);
            this.label_MaxY.TabIndex = 4;
            this.label_MaxY.Text = "MaxY:";
            // 
            // label_MaxZ
            // 
            this.label_MaxZ.AutoSize = true;
            this.label_MaxZ.Location = new System.Drawing.Point(330, 106);
            this.label_MaxZ.Name = "label_MaxZ";
            this.label_MaxZ.Size = new System.Drawing.Size(42, 12);
            this.label_MaxZ.TabIndex = 5;
            this.label_MaxZ.Text = "MaxZ:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(47, 177);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "적용";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tx_min_x
            // 
            this.tx_min_x.Location = new System.Drawing.Point(56, 21);
            this.tx_min_x.Name = "tx_min_x";
            this.tx_min_x.Size = new System.Drawing.Size(100, 21);
            this.tx_min_x.TabIndex = 7;
            // 
            // tx_min_y
            // 
            this.tx_min_y.Location = new System.Drawing.Point(220, 21);
            this.tx_min_y.Name = "tx_min_y";
            this.tx_min_y.Size = new System.Drawing.Size(100, 21);
            this.tx_min_y.TabIndex = 8;
            // 
            // tx_min_z
            // 
            this.tx_min_z.Location = new System.Drawing.Point(378, 21);
            this.tx_min_z.Name = "tx_min_z";
            this.tx_min_z.Size = new System.Drawing.Size(100, 21);
            this.tx_min_z.TabIndex = 9;
            // 
            // tx_max_x
            // 
            this.tx_max_x.Location = new System.Drawing.Point(59, 103);
            this.tx_max_x.Name = "tx_max_x";
            this.tx_max_x.Size = new System.Drawing.Size(100, 21);
            this.tx_max_x.TabIndex = 10;
            // 
            // tx_max_y
            // 
            this.tx_max_y.Location = new System.Drawing.Point(220, 103);
            this.tx_max_y.Name = "tx_max_y";
            this.tx_max_y.Size = new System.Drawing.Size(100, 21);
            this.tx_max_y.TabIndex = 11;
            // 
            // tx_max_z
            // 
            this.tx_max_z.Location = new System.Drawing.Point(378, 103);
            this.tx_max_z.Name = "tx_max_z";
            this.tx_max_z.Size = new System.Drawing.Size(100, 21);
            this.tx_max_z.TabIndex = 12;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(160, 177);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(80, 23);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "다시 설정";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // KartBoundingBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 224);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tx_max_z);
            this.Controls.Add(this.tx_max_y);
            this.Controls.Add(this.tx_max_x);
            this.Controls.Add(this.tx_min_z);
            this.Controls.Add(this.tx_min_y);
            this.Controls.Add(this.tx_min_x);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label_MaxZ);
            this.Controls.Add(this.label_MaxY);
            this.Controls.Add(this.label_MaxX);
            this.Controls.Add(this.label_MinZ);
            this.Controls.Add(this.label_MinY);
            this.Controls.Add(this.label_MinX);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KartBoundingBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KartBoundingBoxTool - by LAON";
            this.Load += new System.EventHandler(this.KartBoundingBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MinX;
        private System.Windows.Forms.Label label_MinY;
        private System.Windows.Forms.Label label_MinZ;
        private System.Windows.Forms.Label label_MaxX;
        private System.Windows.Forms.Label label_MaxY;
        private System.Windows.Forms.Label label_MaxZ;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tx_min_x;
        private System.Windows.Forms.TextBox tx_min_y;
        private System.Windows.Forms.TextBox tx_min_z;
        private System.Windows.Forms.TextBox tx_max_x;
        private System.Windows.Forms.TextBox tx_max_y;
        private System.Windows.Forms.TextBox tx_max_z;
        private System.Windows.Forms.Button btn_Reset;
    }
}