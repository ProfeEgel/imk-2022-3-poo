namespace DentalCareForms
{
    partial class CitasPorPacienteForm
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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.PatientFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientFullName,
            this.DayName,
            this.TimeDescription});
            this.dgvAppointments.Location = new System.Drawing.Point(12, 12);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(396, 278);
            this.dgvAppointments.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(333, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // PatientFullName
            // 
            this.PatientFullName.DataPropertyName = "PatientFullName";
            this.PatientFullName.HeaderText = "Paciente";
            this.PatientFullName.Name = "PatientFullName";
            this.PatientFullName.ReadOnly = true;
            // 
            // DayName
            // 
            this.DayName.DataPropertyName = "DayName";
            this.DayName.HeaderText = "Día";
            this.DayName.Name = "DayName";
            this.DayName.ReadOnly = true;
            // 
            // TimeDescription
            // 
            this.TimeDescription.DataPropertyName = "TimeDescription";
            this.TimeDescription.HeaderText = "Hora";
            this.TimeDescription.Name = "TimeDescription";
            this.TimeDescription.ReadOnly = true;
            // 
            // CitasPorPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(420, 332);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CitasPorPacienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de citas por paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDescription;
    }
}