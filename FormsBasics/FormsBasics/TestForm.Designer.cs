namespace FormsBasics
{
    partial class TestForm
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
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColors = new System.Windows.Forms.TextBox();
            this.chkRojo = new System.Windows.Forms.CheckBox();
            this.chkAzul = new System.Windows.Forms.CheckBox();
            this.chkVerde = new System.Windows.Forms.CheckBox();
            this.chkCyan = new System.Windows.Forms.CheckBox();
            this.chkMagenta = new System.Windows.Forms.CheckBox();
            this.chkAmarillo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlanets = new System.Windows.Forms.TextBox();
            this.radMercurio = new System.Windows.Forms.RadioButton();
            this.radVenus = new System.Windows.Forms.RadioButton();
            this.radTierra = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radJupiter = new System.Windows.Forms.RadioButton();
            this.radSaturno = new System.Windows.Forms.RadioButton();
            this.radMarte = new System.Windows.Forms.RadioButton();
            this.radNeptuno = new System.Windows.Forms.RadioButton();
            this.radUrano = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(371, 27);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(84, 32);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto:";
            // 
            // txtTest
            // 
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(113, 30);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(252, 26);
            this.txtTest.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(461, 27);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 32);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colores:";
            // 
            // txtColors
            // 
            this.txtColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColors.Location = new System.Drawing.Point(113, 72);
            this.txtColors.Name = "txtColors";
            this.txtColors.ReadOnly = true;
            this.txtColors.Size = new System.Drawing.Size(432, 26);
            this.txtColors.TabIndex = 2;
            // 
            // chkRojo
            // 
            this.chkRojo.AutoSize = true;
            this.chkRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRojo.Location = new System.Drawing.Point(113, 113);
            this.chkRojo.Name = "chkRojo";
            this.chkRojo.Size = new System.Drawing.Size(61, 24);
            this.chkRojo.TabIndex = 4;
            this.chkRojo.Text = "Rojo";
            this.chkRojo.UseVisualStyleBackColor = true;
            this.chkRojo.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkAzul
            // 
            this.chkAzul.AutoSize = true;
            this.chkAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAzul.Location = new System.Drawing.Point(113, 143);
            this.chkAzul.Name = "chkAzul";
            this.chkAzul.Size = new System.Drawing.Size(59, 24);
            this.chkAzul.TabIndex = 4;
            this.chkAzul.Text = "Azul";
            this.chkAzul.UseVisualStyleBackColor = true;
            this.chkAzul.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkVerde
            // 
            this.chkVerde.AutoSize = true;
            this.chkVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVerde.Location = new System.Drawing.Point(113, 173);
            this.chkVerde.Name = "chkVerde";
            this.chkVerde.Size = new System.Drawing.Size(71, 24);
            this.chkVerde.TabIndex = 4;
            this.chkVerde.Text = "Verde";
            this.chkVerde.UseVisualStyleBackColor = true;
            this.chkVerde.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkCyan
            // 
            this.chkCyan.AutoSize = true;
            this.chkCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCyan.Location = new System.Drawing.Point(259, 113);
            this.chkCyan.Name = "chkCyan";
            this.chkCyan.Size = new System.Drawing.Size(64, 24);
            this.chkCyan.TabIndex = 4;
            this.chkCyan.Text = "Cyan";
            this.chkCyan.UseVisualStyleBackColor = true;
            this.chkCyan.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkMagenta
            // 
            this.chkMagenta.AutoSize = true;
            this.chkMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMagenta.Location = new System.Drawing.Point(259, 143);
            this.chkMagenta.Name = "chkMagenta";
            this.chkMagenta.Size = new System.Drawing.Size(91, 24);
            this.chkMagenta.TabIndex = 4;
            this.chkMagenta.Text = "Magenta";
            this.chkMagenta.UseVisualStyleBackColor = true;
            this.chkMagenta.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkAmarillo
            // 
            this.chkAmarillo.AutoSize = true;
            this.chkAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAmarillo.Location = new System.Drawing.Point(259, 173);
            this.chkAmarillo.Name = "chkAmarillo";
            this.chkAmarillo.Size = new System.Drawing.Size(84, 24);
            this.chkAmarillo.TabIndex = 4;
            this.chkAmarillo.Text = "Amarillo";
            this.chkAmarillo.UseVisualStyleBackColor = true;
            this.chkAmarillo.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Planeta:";
            // 
            // txtPlanets
            // 
            this.txtPlanets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanets.Location = new System.Drawing.Point(113, 213);
            this.txtPlanets.Name = "txtPlanets";
            this.txtPlanets.ReadOnly = true;
            this.txtPlanets.Size = new System.Drawing.Size(210, 26);
            this.txtPlanets.TabIndex = 2;
            // 
            // radMercurio
            // 
            this.radMercurio.AutoSize = true;
            this.radMercurio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMercurio.Location = new System.Drawing.Point(23, 28);
            this.radMercurio.Name = "radMercurio";
            this.radMercurio.Size = new System.Drawing.Size(85, 22);
            this.radMercurio.TabIndex = 5;
            this.radMercurio.TabStop = true;
            this.radMercurio.Text = "Mercurio";
            this.radMercurio.UseVisualStyleBackColor = true;
            this.radMercurio.CheckedChanged += new System.EventHandler(this.radMercurio_CheckedChanged);
            // 
            // radVenus
            // 
            this.radVenus.AutoSize = true;
            this.radVenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVenus.Location = new System.Drawing.Point(23, 58);
            this.radVenus.Name = "radVenus";
            this.radVenus.Size = new System.Drawing.Size(67, 22);
            this.radVenus.TabIndex = 5;
            this.radVenus.TabStop = true;
            this.radVenus.Text = "Venus";
            this.radVenus.UseVisualStyleBackColor = true;
            this.radVenus.CheckedChanged += new System.EventHandler(this.radMercurio_CheckedChanged);
            // 
            // radTierra
            // 
            this.radTierra.AutoSize = true;
            this.radTierra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTierra.Location = new System.Drawing.Point(23, 88);
            this.radTierra.Name = "radTierra";
            this.radTierra.Size = new System.Drawing.Size(64, 22);
            this.radTierra.TabIndex = 5;
            this.radTierra.TabStop = true;
            this.radTierra.Text = "Tierra";
            this.radTierra.UseVisualStyleBackColor = true;
            this.radTierra.CheckedChanged += new System.EventHandler(this.radMercurio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUrano);
            this.groupBox1.Controls.Add(this.radMarte);
            this.groupBox1.Controls.Add(this.radMercurio);
            this.groupBox1.Controls.Add(this.radSaturno);
            this.groupBox1.Controls.Add(this.radNeptuno);
            this.groupBox1.Controls.Add(this.radTierra);
            this.groupBox1.Controls.Add(this.radJupiter);
            this.groupBox1.Controls.Add(this.radVenus);
            this.groupBox1.Location = new System.Drawing.Point(113, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planetas";
            // 
            // radJupiter
            // 
            this.radJupiter.AutoSize = true;
            this.radJupiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJupiter.Location = new System.Drawing.Point(158, 58);
            this.radJupiter.Name = "radJupiter";
            this.radJupiter.Size = new System.Drawing.Size(70, 22);
            this.radJupiter.TabIndex = 5;
            this.radJupiter.TabStop = true;
            this.radJupiter.Text = "Jupiter";
            this.radJupiter.UseVisualStyleBackColor = true;
            this.radJupiter.CheckedChanged += new System.EventHandler(this.radMercurio_CheckedChanged);
            // 
            // radSaturno
            // 
            this.radSaturno.AutoSize = true;
            this.radSaturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSaturno.Location = new System.Drawing.Point(158, 88);
            this.radSaturno.Name = "radSaturno";
            this.radSaturno.Size = new System.Drawing.Size(78, 22);
            this.radSaturno.TabIndex = 5;
            this.radSaturno.TabStop = true;
            this.radSaturno.Text = "Saturno";
            this.radSaturno.UseVisualStyleBackColor = true;
            this.radSaturno.CheckedChanged += new System.EventHandler(this.radMercurio_CheckedChanged);
            // 
            // radMarte
            // 
            this.radMarte.AutoSize = true;
            this.radMarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMarte.Location = new System.Drawing.Point(158, 28);
            this.radMarte.Name = "radMarte";
            this.radMarte.Size = new System.Drawing.Size(64, 22);
            this.radMarte.TabIndex = 5;
            this.radMarte.TabStop = true;
            this.radMarte.Text = "Marte";
            this.radMarte.UseVisualStyleBackColor = true;
            this.radMarte.CheckedChanged += new System.EventHandler(this.radMercurio_CheckedChanged);
            // 
            // radNeptuno
            // 
            this.radNeptuno.AutoSize = true;
            this.radNeptuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNeptuno.Location = new System.Drawing.Point(296, 58);
            this.radNeptuno.Name = "radNeptuno";
            this.radNeptuno.Size = new System.Drawing.Size(82, 22);
            this.radNeptuno.TabIndex = 5;
            this.radNeptuno.TabStop = true;
            this.radNeptuno.Text = "Neptuno";
            this.radNeptuno.UseVisualStyleBackColor = true;
            this.radNeptuno.CheckedChanged += new System.EventHandler(this.radMercurio_CheckedChanged);
            // 
            // radUrano
            // 
            this.radUrano.AutoSize = true;
            this.radUrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUrano.Location = new System.Drawing.Point(296, 28);
            this.radUrano.Name = "radUrano";
            this.radUrano.Size = new System.Drawing.Size(67, 22);
            this.radUrano.TabIndex = 5;
            this.radUrano.TabStop = true;
            this.radUrano.Text = "Urano";
            this.radUrano.UseVisualStyleBackColor = true;
            this.radUrano.CheckedChanged += new System.EventHandler(this.radMercurio_CheckedChanged);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAmarillo);
            this.Controls.Add(this.chkVerde);
            this.Controls.Add(this.chkMagenta);
            this.Controls.Add(this.chkAzul);
            this.Controls.Add(this.chkCyan);
            this.Controls.Add(this.chkRojo);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtPlanets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColors;
        private System.Windows.Forms.CheckBox chkRojo;
        private System.Windows.Forms.CheckBox chkAzul;
        private System.Windows.Forms.CheckBox chkVerde;
        private System.Windows.Forms.CheckBox chkCyan;
        private System.Windows.Forms.CheckBox chkMagenta;
        private System.Windows.Forms.CheckBox chkAmarillo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlanets;
        private System.Windows.Forms.RadioButton radMercurio;
        private System.Windows.Forms.RadioButton radVenus;
        private System.Windows.Forms.RadioButton radTierra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radUrano;
        private System.Windows.Forms.RadioButton radMarte;
        private System.Windows.Forms.RadioButton radSaturno;
        private System.Windows.Forms.RadioButton radNeptuno;
        private System.Windows.Forms.RadioButton radJupiter;
    }
}

