Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml.Serialization

Public Class Form1
    Private Shared list As New List(Of String)()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim filename As String = "EmpTable.csv"
        'MsgBox(File.ReadAllText(filename))
        If File.Exists("EmpState.xml") Then
            Dim fs As New FileStream("EmpState.xml", FileMode.Open, FileAccess.Read)
            Dim br As New XmlSerializer(GetType(Employee))
            Dim emp As Employee = br.Deserialize(fs)
            txtId.Text = emp.EmpId
            txtName.Text = emp.EmpName
            txtAddress.Text = emp.EmpAddress
            fs.Close()
        End If
    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim component As IDataComponent = New DataComponent
            Dim data = component.FindEmployee(txtFind.Text)
            ListBox1.DataSource = data
            ListBox1.DisplayMember = "EmpName"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selectedItem As Employee = ListBox1.SelectedItem
        txtId.Text = selectedItem.EmpId.ToString
        txtSalary.Text = selectedItem.EmpSalary.ToString
        txtName.Text = selectedItem.EmpName
        txtAddress.Text = selectedItem.EmpAddress
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim employee As New Employee
        employee.EmpId = txtId.Text
        employee.EmpName = txtName.Text
        employee.EmpAddress = txtAddress.Text
        employee.EmpSalary = txtSalary.Text
        Dim com As New DataComponent
        com.AddEmployee(employee)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim employee As New Employee
        employee.EmpId = txtId.Text
        employee.EmpName = txtName.Text
        employee.EmpAddress = txtAddress.Text
        employee.EmpSalary = txtSalary.Text
        Dim com As New DataComponent
        com.UpdateEmployee(employee)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportData("EmpTable")
    End Sub

    Private Sub ExportData(strTable As String)
        Dim lines As New List(Of String)
        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
        Dim cmd As New SqlCommand($"SELECT * FROM {strTable}", con)
        Dim filename As String = $"{strTable}.csv"
        Try
            con.Open()
            Dim reader = cmd.ExecuteReader()
            While reader.Read
                Dim line = ""
                For index = 0 To reader.FieldCount - 1
                    line += reader(index) & "," ' Use & for string concatination
                Next
                line = line.Trim(",")
                lines.Add(line)
            End While
            File.WriteAllLines(filename, lines.ToArray())
            list = lines 'copies all the data of lines into list(static variable)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Code to save the data.
        'Dim msgResult = MsgBox("DO U WANT TO SAVE AND CLOSE THE APP?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo)
        'If msgResult = MsgBoxResult.Yes Then
        '    ExportData("EmpTable")
        'Else
        '    e.Cancel = True
        'End If
        Dim fs As New FileStream("EmpState.xml", FileMode.OpenOrCreate, FileAccess.Write)
        Dim br As New XmlSerializer(GetType(Employee))
        Dim emp As New Employee
        emp.EmpId = Val(txtId.Text)
        emp.EmpAddress = txtAddress.Text
        emp.EmpSalary = Val(txtSalary.Text)
        emp.EmpName = txtName.Text
        br.Serialize(fs, emp)
        fs.Close()
    End Sub
End Class
