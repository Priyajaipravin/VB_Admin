<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_next = New System.Windows.Forms.Button()
        Me.b_previous = New System.Windows.Forms.Button()
        Me.B_update = New System.Windows.Forms.Button()
        Me.b_save = New System.Windows.Forms.Button()
        Me.l_photo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cb_gender = New System.Windows.Forms.ComboBox()
        Me.l_password = New System.Windows.Forms.Label()
        Me.l_mail = New System.Windows.Forms.Label()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_mailid = New System.Windows.Forms.TextBox()
        Me.tb_phone = New System.Windows.Forms.TextBox()
        Me.tb_department = New System.Windows.Forms.TextBox()
        Me.tb_designation = New System.Windows.Forms.TextBox()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.tb_prno = New System.Windows.Forms.TextBox()
        Me.l_phone = New System.Windows.Forms.Label()
        Me.l_department = New System.Windows.Forms.Label()
        Me.l_gender = New System.Windows.Forms.Label()
        Me.l_disignation = New System.Windows.Forms.Label()
        Me.prno_l = New System.Windows.Forms.Label()
        Me.L_Name = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.l_registration = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.l_register = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.l_by = New System.Windows.Forms.Label()
        Me.l_search = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.b_refresh = New System.Windows.Forms.Button()
        Me.b_edit = New System.Windows.Forms.Button()
        Me.b_Delete = New System.Windows.Forms.Button()
        Me.b_deselect = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RG_DGV = New System.Windows.Forms.DataGridView()
        Me.db_prno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_designation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.db_image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.RG_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightPink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.b_next)
        Me.Panel1.Controls.Add(Me.b_previous)
        Me.Panel1.Controls.Add(Me.B_update)
        Me.Panel1.Controls.Add(Me.b_save)
        Me.Panel1.Controls.Add(Me.l_photo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cb_gender)
        Me.Panel1.Controls.Add(Me.l_password)
        Me.Panel1.Controls.Add(Me.l_mail)
        Me.Panel1.Controls.Add(Me.tb_password)
        Me.Panel1.Controls.Add(Me.tb_mailid)
        Me.Panel1.Controls.Add(Me.tb_phone)
        Me.Panel1.Controls.Add(Me.tb_department)
        Me.Panel1.Controls.Add(Me.tb_designation)
        Me.Panel1.Controls.Add(Me.tb_name)
        Me.Panel1.Controls.Add(Me.tb_prno)
        Me.Panel1.Controls.Add(Me.l_phone)
        Me.Panel1.Controls.Add(Me.l_department)
        Me.Panel1.Controls.Add(Me.l_gender)
        Me.Panel1.Controls.Add(Me.l_disignation)
        Me.Panel1.Controls.Add(Me.prno_l)
        Me.Panel1.Controls.Add(Me.L_Name)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1115, 304)
        Me.Panel1.TabIndex = 0
        '
        'b_next
        '
        Me.b_next.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.b_next.Location = New System.Drawing.Point(984, 173)
        Me.b_next.Name = "b_next"
        Me.b_next.Size = New System.Drawing.Size(96, 27)
        Me.b_next.TabIndex = 23
        Me.b_next.Text = "Next"
        Me.b_next.UseVisualStyleBackColor = True
        '
        'b_previous
        '
        Me.b_previous.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.b_previous.Location = New System.Drawing.Point(878, 173)
        Me.b_previous.Name = "b_previous"
        Me.b_previous.Size = New System.Drawing.Size(96, 27)
        Me.b_previous.TabIndex = 22
        Me.b_previous.Text = "Previous"
        Me.b_previous.UseVisualStyleBackColor = True
        '
        'B_update
        '
        Me.B_update.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.B_update.Location = New System.Drawing.Point(984, 112)
        Me.B_update.Name = "B_update"
        Me.B_update.Size = New System.Drawing.Size(96, 27)
        Me.B_update.TabIndex = 21
        Me.B_update.Text = "Update"
        Me.B_update.UseVisualStyleBackColor = True
        '
        'b_save
        '
        Me.b_save.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.b_save.Location = New System.Drawing.Point(878, 112)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(96, 27)
        Me.b_save.TabIndex = 20
        Me.b_save.Text = "Save"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'l_photo
        '
        Me.l_photo.AutoSize = True
        Me.l_photo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_photo.Location = New System.Drawing.Point(752, 52)
        Me.l_photo.Name = "l_photo"
        Me.l_photo.Size = New System.Drawing.Size(46, 17)
        Me.l_photo.TabIndex = 19
        Me.l_photo.Text = "Photo"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightYellow
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(682, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'cb_gender
        '
        Me.cb_gender.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_gender.FormattingEnabled = True
        Me.cb_gender.Items.AddRange(New Object() {"MALE", "FEMALE", "TRANSGENDER"})
        Me.cb_gender.Location = New System.Drawing.Point(282, 148)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(366, 22)
        Me.cb_gender.TabIndex = 17
        '
        'l_password
        '
        Me.l_password.AutoSize = True
        Me.l_password.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_password.Location = New System.Drawing.Point(133, 270)
        Me.l_password.Name = "l_password"
        Me.l_password.Size = New System.Drawing.Size(70, 17)
        Me.l_password.TabIndex = 16
        Me.l_password.Text = "Password"
        '
        'l_mail
        '
        Me.l_mail.AutoSize = True
        Me.l_mail.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_mail.Location = New System.Drawing.Point(133, 241)
        Me.l_mail.Name = "l_mail"
        Me.l_mail.Size = New System.Drawing.Size(63, 17)
        Me.l_mail.TabIndex = 15
        Me.l_mail.Text = "Mail_ID"
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_password.Location = New System.Drawing.Point(282, 264)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(366, 20)
        Me.tb_password.TabIndex = 14
        '
        'tb_mailid
        '
        Me.tb_mailid.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_mailid.Location = New System.Drawing.Point(282, 235)
        Me.tb_mailid.Name = "tb_mailid"
        Me.tb_mailid.Size = New System.Drawing.Size(366, 20)
        Me.tb_mailid.TabIndex = 13
        '
        'tb_phone
        '
        Me.tb_phone.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_phone.Location = New System.Drawing.Point(282, 206)
        Me.tb_phone.Name = "tb_phone"
        Me.tb_phone.Size = New System.Drawing.Size(366, 20)
        Me.tb_phone.TabIndex = 12
        '
        'tb_department
        '
        Me.tb_department.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_department.Location = New System.Drawing.Point(282, 177)
        Me.tb_department.Name = "tb_department"
        Me.tb_department.Size = New System.Drawing.Size(366, 20)
        Me.tb_department.TabIndex = 11
        '
        'tb_designation
        '
        Me.tb_designation.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_designation.Location = New System.Drawing.Point(282, 119)
        Me.tb_designation.Name = "tb_designation"
        Me.tb_designation.Size = New System.Drawing.Size(366, 20)
        Me.tb_designation.TabIndex = 9
        '
        'tb_name
        '
        Me.tb_name.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_name.Location = New System.Drawing.Point(282, 90)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(366, 20)
        Me.tb_name.TabIndex = 8
        '
        'tb_prno
        '
        Me.tb_prno.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_prno.Location = New System.Drawing.Point(282, 61)
        Me.tb_prno.Name = "tb_prno"
        Me.tb_prno.Size = New System.Drawing.Size(366, 20)
        Me.tb_prno.TabIndex = 7
        '
        'l_phone
        '
        Me.l_phone.AutoSize = True
        Me.l_phone.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_phone.Location = New System.Drawing.Point(133, 212)
        Me.l_phone.Name = "l_phone"
        Me.l_phone.Size = New System.Drawing.Size(106, 17)
        Me.l_phone.TabIndex = 6
        Me.l_phone.Text = "Phone Number"
        '
        'l_department
        '
        Me.l_department.AutoSize = True
        Me.l_department.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_department.Location = New System.Drawing.Point(133, 183)
        Me.l_department.Name = "l_department"
        Me.l_department.Size = New System.Drawing.Size(86, 17)
        Me.l_department.TabIndex = 5
        Me.l_department.Text = "Department"
        '
        'l_gender
        '
        Me.l_gender.AutoSize = True
        Me.l_gender.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_gender.Location = New System.Drawing.Point(133, 153)
        Me.l_gender.Name = "l_gender"
        Me.l_gender.Size = New System.Drawing.Size(57, 17)
        Me.l_gender.TabIndex = 4
        Me.l_gender.Text = "Gender"
        '
        'l_disignation
        '
        Me.l_disignation.AutoSize = True
        Me.l_disignation.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_disignation.Location = New System.Drawing.Point(133, 125)
        Me.l_disignation.Name = "l_disignation"
        Me.l_disignation.Size = New System.Drawing.Size(86, 17)
        Me.l_disignation.TabIndex = 3
        Me.l_disignation.Text = "Designation"
        '
        'prno_l
        '
        Me.prno_l.AutoSize = True
        Me.prno_l.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.prno_l.Location = New System.Drawing.Point(133, 67)
        Me.prno_l.Name = "prno_l"
        Me.prno_l.Size = New System.Drawing.Size(45, 17)
        Me.prno_l.TabIndex = 2
        Me.prno_l.Text = "Pr.No"
        '
        'L_Name
        '
        Me.L_Name.AutoSize = True
        Me.L_Name.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.L_Name.Location = New System.Drawing.Point(133, 96)
        Me.L_Name.Name = "L_Name"
        Me.L_Name.Size = New System.Drawing.Size(46, 17)
        Me.L_Name.TabIndex = 1
        Me.L_Name.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCoral
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.l_registration)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1113, 40)
        Me.Panel2.TabIndex = 0
        '
        'l_registration
        '
        Me.l_registration.AutoSize = True
        Me.l_registration.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_registration.Location = New System.Drawing.Point(9, 6)
        Me.l_registration.Name = "l_registration"
        Me.l_registration.Size = New System.Drawing.Size(168, 24)
        Me.l_registration.TabIndex = 0
        Me.l_registration.Text = "Staff Registration"
        Me.l_registration.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.RG_DGV)
        Me.Panel3.Controls.Add(Me.b_deselect)
        Me.Panel3.Controls.Add(Me.b_Delete)
        Me.Panel3.Controls.Add(Me.b_edit)
        Me.Panel3.Controls.Add(Me.b_refresh)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.l_search)
        Me.Panel3.Controls.Add(Me.l_by)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(3, 310)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1114, 368)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightCoral
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.l_register)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1114, 31)
        Me.Panel4.TabIndex = 1
        '
        'l_register
        '
        Me.l_register.AutoSize = True
        Me.l_register.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_register.Location = New System.Drawing.Point(-1, 5)
        Me.l_register.Name = "l_register"
        Me.l_register.Size = New System.Drawing.Size(84, 24)
        Me.l_register.TabIndex = 0
        Me.l_register.Text = "Register"
        Me.l_register.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(68, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(559, 20)
        Me.TextBox1.TabIndex = 15
        '
        'l_by
        '
        Me.l_by.AutoSize = True
        Me.l_by.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_by.Location = New System.Drawing.Point(633, 40)
        Me.l_by.Name = "l_by"
        Me.l_by.Size = New System.Drawing.Size(26, 17)
        Me.l_by.TabIndex = 16
        Me.l_by.Text = "By"
        '
        'l_search
        '
        Me.l_search.AutoSize = True
        Me.l_search.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l_search.Location = New System.Drawing.Point(10, 40)
        Me.l_search.Name = "l_search"
        Me.l_search.Size = New System.Drawing.Size(52, 17)
        Me.l_search.TabIndex = 17
        Me.l_search.Text = "Search"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE", "TRANSGENDER"})
        Me.ComboBox1.Location = New System.Drawing.Point(665, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(177, 22)
        Me.ComboBox1.TabIndex = 18
        '
        'b_refresh
        '
        Me.b_refresh.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.b_refresh.Location = New System.Drawing.Point(272, 77)
        Me.b_refresh.Name = "b_refresh"
        Me.b_refresh.Size = New System.Drawing.Size(96, 27)
        Me.b_refresh.TabIndex = 21
        Me.b_refresh.Text = "Refresh"
        Me.b_refresh.UseVisualStyleBackColor = True
        '
        'b_edit
        '
        Me.b_edit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.b_edit.Location = New System.Drawing.Point(68, 77)
        Me.b_edit.Name = "b_edit"
        Me.b_edit.Size = New System.Drawing.Size(96, 27)
        Me.b_edit.TabIndex = 22
        Me.b_edit.Text = "Edit"
        Me.b_edit.UseVisualStyleBackColor = True
        '
        'b_Delete
        '
        Me.b_Delete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.b_Delete.Location = New System.Drawing.Point(170, 77)
        Me.b_Delete.Name = "b_Delete"
        Me.b_Delete.Size = New System.Drawing.Size(96, 27)
        Me.b_Delete.TabIndex = 23
        Me.b_Delete.Text = "Delete"
        Me.b_Delete.UseVisualStyleBackColor = True
        '
        'b_deselect
        '
        Me.b_deselect.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.b_deselect.Location = New System.Drawing.Point(374, 77)
        Me.b_deselect.Name = "b_deselect"
        Me.b_deselect.Size = New System.Drawing.Size(123, 27)
        Me.b_deselect.TabIndex = 24
        Me.b_deselect.Text = "Clear Selection"
        Me.b_deselect.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RG_DGV
        '
        Me.RG_DGV.AllowUserToAddRows = False
        Me.RG_DGV.AllowUserToDeleteRows = False
        Me.RG_DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.RG_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RG_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.RG_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.RG_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RG_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.db_prno, Me.db_name, Me.db_gender, Me.db_department, Me.db_designation, Me.db_phone, Me.db_mail, Me.db_password, Me.db_image})
        Me.RG_DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RG_DGV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RG_DGV.Location = New System.Drawing.Point(0, 113)
        Me.RG_DGV.Name = "RG_DGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RG_DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.RG_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.RG_DGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.RG_DGV.RowTemplate.Height = 25
        Me.RG_DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RG_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RG_DGV.Size = New System.Drawing.Size(1114, 255)
        Me.RG_DGV.TabIndex = 25
        '
        'db_prno
        '
        Me.db_prno.HeaderText = "Pr.No"
        Me.db_prno.Name = "db_prno"
        '
        'db_name
        '
        Me.db_name.HeaderText = "Name"
        Me.db_name.Name = "db_name"
        '
        'db_gender
        '
        Me.db_gender.HeaderText = "Gender"
        Me.db_gender.Name = "db_gender"
        '
        'db_department
        '
        Me.db_department.HeaderText = "Department"
        Me.db_department.Name = "db_department"
        '
        'db_designation
        '
        Me.db_designation.HeaderText = "designation"
        Me.db_designation.Name = "db_designation"
        '
        'db_phone
        '
        Me.db_phone.HeaderText = "Phone Number"
        Me.db_phone.Name = "db_phone"
        '
        'db_mail
        '
        Me.db_mail.HeaderText = "Mail_ID"
        Me.db_mail.Name = "db_mail"
        '
        'db_password
        '
        Me.db_password.HeaderText = "Password"
        Me.db_password.Name = "db_password"
        '
        'db_image
        '
        Me.db_image.HeaderText = "Photo"
        Me.db_image.Name = "db_image"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 690)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.RG_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents b_next As Button
    Friend WithEvents b_previous As Button
    Friend WithEvents B_update As Button
    Friend WithEvents b_save As Button
    Friend WithEvents l_photo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cb_gender As ComboBox
    Friend WithEvents l_password As Label
    Friend WithEvents l_mail As Label
    Friend WithEvents tb_password As TextBox
    Friend WithEvents tb_mailid As TextBox
    Friend WithEvents tb_phone As TextBox
    Friend WithEvents tb_department As TextBox
    Friend WithEvents tb_designation As TextBox
    Friend WithEvents tb_name As TextBox
    Friend WithEvents tb_prno As TextBox
    Friend WithEvents l_phone As Label
    Friend WithEvents l_department As Label
    Friend WithEvents l_gender As Label
    Friend WithEvents l_disignation As Label
    Friend WithEvents prno_l As Label
    Friend WithEvents L_Name As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents l_registration As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents l_register As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RG_DGV As DataGridView
    Friend WithEvents db_prno As DataGridViewTextBoxColumn
    Friend WithEvents db_name As DataGridViewTextBoxColumn
    Friend WithEvents db_gender As DataGridViewTextBoxColumn
    Friend WithEvents db_department As DataGridViewTextBoxColumn
    Friend WithEvents db_designation As DataGridViewTextBoxColumn
    Friend WithEvents db_phone As DataGridViewTextBoxColumn
    Friend WithEvents db_mail As DataGridViewTextBoxColumn
    Friend WithEvents db_password As DataGridViewTextBoxColumn
    Friend WithEvents db_image As DataGridViewImageColumn
    Friend WithEvents b_deselect As Button
    Friend WithEvents b_Delete As Button
    Friend WithEvents b_edit As Button
    Friend WithEvents b_refresh As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents l_search As Label
    Friend WithEvents l_by As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
