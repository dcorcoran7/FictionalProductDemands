<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserProductDemand
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.btnShowDemand = New System.Windows.Forms.Button()
        Me.btnShowAllDemand = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(110, 51)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(160, 26)
        Me.txtProduct.TabIndex = 0
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(110, 97)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(160, 26)
        Me.txtYear.TabIndex = 1
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(40, 54)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(64, 20)
        Me.lblProduct.TabIndex = 2
        Me.lblProduct.Text = "Product"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(49, 100)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(43, 20)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year"
        '
        'btnShowDemand
        '
        Me.btnShowDemand.Location = New System.Drawing.Point(110, 149)
        Me.btnShowDemand.Name = "btnShowDemand"
        Me.btnShowDemand.Size = New System.Drawing.Size(160, 30)
        Me.btnShowDemand.TabIndex = 4
        Me.btnShowDemand.Text = "Show Demand"
        Me.btnShowDemand.UseVisualStyleBackColor = True
        '
        'btnShowAllDemand
        '
        Me.btnShowAllDemand.Location = New System.Drawing.Point(110, 195)
        Me.btnShowAllDemand.Name = "btnShowAllDemand"
        Me.btnShowAllDemand.Size = New System.Drawing.Size(160, 30)
        Me.btnShowAllDemand.TabIndex = 5
        Me.btnShowAllDemand.Text = "Show All Demand"
        Me.btnShowAllDemand.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(110, 241)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(160, 30)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmUserProductDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 317)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShowAllDemand)
        Me.Controls.Add(Me.btnShowDemand)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtProduct)
        Me.Name = "frmUserProductDemand"
        Me.Text = "Demand"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents btnShowDemand As Button
    Friend WithEvents btnShowAllDemand As Button
    Friend WithEvents btnClose As Button
End Class
