
namespace lv2_objektno
{
    partial class Form1
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
            this.gbShapes = new System.Windows.Forms.GroupBox();
            this.rbPolygon = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.gbColors = new System.Windows.Forms.GroupBox();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.gbShapes.SuspendLayout();
            this.gbColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbShapes
            // 
            this.gbShapes.Controls.Add(this.rbPolygon);
            this.gbShapes.Controls.Add(this.rbEllipse);
            this.gbShapes.Controls.Add(this.rbCircle);
            this.gbShapes.Controls.Add(this.rbRectangle);
            this.gbShapes.Controls.Add(this.rbLine);
            this.gbShapes.Location = new System.Drawing.Point(569, 25);
            this.gbShapes.Name = "gbShapes";
            this.gbShapes.Size = new System.Drawing.Size(200, 182);
            this.gbShapes.TabIndex = 0;
            this.gbShapes.TabStop = false;
            this.gbShapes.Text = "Oblici";
            // 
            // rbPolygon
            // 
            this.rbPolygon.AutoSize = true;
            this.rbPolygon.Location = new System.Drawing.Point(16, 127);
            this.rbPolygon.Name = "rbPolygon";
            this.rbPolygon.Size = new System.Drawing.Size(60, 17);
            this.rbPolygon.TabIndex = 4;
            this.rbPolygon.TabStop = true;
            this.rbPolygon.Text = "Poligon";
            this.rbPolygon.UseVisualStyleBackColor = true;
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(16, 104);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(53, 17);
            this.rbEllipse.TabIndex = 3;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Elipsa";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(16, 81);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(66, 17);
            this.rbCircle.TabIndex = 2;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Kruznica";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(16, 58);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(82, 17);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Pravokutnik";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(16, 35);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(49, 17);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Linija";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // gbColors
            // 
            this.gbColors.Controls.Add(this.rbBlue);
            this.gbColors.Controls.Add(this.rbBlack);
            this.gbColors.Controls.Add(this.rbRed);
            this.gbColors.Location = new System.Drawing.Point(569, 273);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(200, 120);
            this.gbColors.TabIndex = 1;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "Boje";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(16, 78);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(52, 17);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Plava";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(17, 55);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(47, 17);
            this.rbBlack.TabIndex = 1;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Crna";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(16, 32);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(59, 17);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Crvena";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbColors);
            this.Controls.Add(this.gbShapes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gbShapes.ResumeLayout(false);
            this.gbShapes.PerformLayout();
            this.gbColors.ResumeLayout(false);
            this.gbColors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbShapes;
        private System.Windows.Forms.RadioButton rbPolygon;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.GroupBox gbColors;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbRed;
    }
}

