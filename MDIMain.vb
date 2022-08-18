Imports System.Windows.Forms
Imports Excel = Microsoft.Office.Interop.Excel


Public Class MDIMain
    Dim minMaintenance As Integer
    Dim minPurchase As Integer
    Dim minSales As Integer
    Dim critical As Integer




    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Create a new instance of the child form.
    '    Dim ChildForm As New System.Windows.Forms.Form
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Window " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub

    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim OpenFileDialog As New OpenFileDialog
    '    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    '    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = OpenFileDialog.FileName
    '        ' TODO: Add code here to open the file.
    '    End If
    'End Sub

    'Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim SaveFileDialog As New SaveFileDialog
    '    SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

    '    If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = SaveFileDialog.FileName
    '        ' TODO: Add code here to save the current contents of the form to a file.
    '    End If
    'End Sub


    'Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.Close()
    'End Sub

    'Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    'End Sub

    'Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    'End Sub

    'Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    'End Sub

    'Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.Cascade)
    'End Sub

    'Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.TileVertical)
    'End Sub

    'Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.TileHorizontal)
    'End Sub

    'Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.ArrangeIcons)
    'End Sub

    'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Close all child forms of the parent.
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    'End Sub

    'Private m_ChildFormNumber As Integer

    'Private Sub MDIMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    'aget()
    '    If gFirstTime = 0 Then


    '        globalList = New FrmCatList
    '        Proionta = New FrmCatList
    '        KAPROI = New FrmCatList
    '        gFirstTime = gFirstTime + 1
    '    End If



    'End Sub

    'Private Sub MDIMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    If MsgBox("Θέλετε να κλείσετε το πρόγραμμα ??", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.No Then
    '        e.Cancel = 1
    '    Else
    '        sqlSTR = "UPDATE TBL_Audit_Log SET LOGOUT ='" & TimeOfDay & "' WHERE User_ID =" & xUser_ID & " AND LOG_ID=" & LOGID
    '        ExecuteSQLQuery(sqlSTR)

    '    End If
    'End Sub

    'Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    gConnect = "Data Source=localhost\SQLEXPRESS;Integrated Security=True;database=SaleInv_DB"
    '    'If username = "" Then
    '    ' End
    '    ' End If
    '    'xUser_Access = "Administrator"
    '    checkServer()
    '    '  
    '    'Me.Text = "συνδεθήκατε με την βαση δεδομένων"
    '    Me.lblUser.Text = username
    '    MDIDISABLED()







    '    'Public gPHDHMAGENNA As Integer
    '    'Public gPHDHMAnextOXEIA As Integer
    '    'Public gAPOGnextOXEIA As Integer



    '    ExecuteSQLQuery("SELECT * FROM TBL_Globaldata")
    '    Me.WindowState = FormWindowState.Maximized
    '    PanelAdvisory.Width = Me.Width
    '    PanelHoldAdvisory.Width = Me.Width





    '    If sqlDT.Rows.Count > 0 Then
    '        VAT = sqlDT.Rows(0)("BussVat")
    '        ParamCompanyName.Value = sqlDT.Rows(0)("BussName")
    '        ParamCompanyLoc.Value = sqlDT.Rows(0)("BussLocation")
    '        ParamCompanyContact.Value = sqlDT.Rows(0)("BussContact")
    '        ParamCompanyTIN.Value = sqlDT.Rows(0)("Tin")
    '    End If


    '    sqlSTR = "SELECT * FROM PARAMETROI"
    '    ExecuteSQLQuery(sqlSTR)
    '    gPHDHMAnextOXEIA = sqlDT.Rows(0)("PHDHMANEXTOXEIA")
    '    gPHDHMAGENNA = sqlDT.Rows(0)("PHDHMAGENNA")
    '    gAPOGnextOXEIA = sqlDT.Rows(0)("APOGNEXTOXEIA")





    '    With FrmBG
    '        .MdiParent = Me
    '        '.WindowState = Me.WindowState
    '        .WindowState = FormWindowState.Maximized
    '        '.pics.Left = (Me.Width / 2) - (.pics.Width / 2)
    '        'pics.Left = (Me.Width / 2) - (pics.Width / 2)
    '        '.Width = Me.Width - (ToolStrip1.Width - TSHold.Width)
    '        .Show()
    '    End With
    '    With TSHoldRight
    '        PanelShortCut.Top = .Top - 15
    '        PanelShortCut.Left = .Left - 1
    '    End With
    '    FrmLOGIN.ShowDialog()
    '    LinkMaintain_LinkClicked(0, AcceptButton)
    '    LinkPurchasing_LinkClicked(0, AcceptButton)
    '    LinkSales_LinkClicked(0, AcceptButton)
    '    cmdLock.Enabled = True
    '    RefreshList(ActiveMdiChild.Name)
    '    ' FrmAbout.ShowDialog()
    '    'MsgBox(Me.Width)
    'End Sub

    'Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    '    If MsgBox("Do you really want to exit the system ??", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sales and Inventory") = MsgBoxResult.Yes Then
    '        End
    '    End If
    'End Sub

    'Private Sub UserInformationFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserInformationFileToolStripMenuItem.Click
    '    'If x_Access(xUser_Access) Then
    '    Audit_Trail(xUser_ID, TimeOfDay, "View User Account Info")
    '    FrmSysUser.ShowDialog()
    '    ' End If
    'End Sub

    'Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
    '    'ToolStrip1.Visible = True
    '    cmdManageSuppliers_Click(0, AcceptButton)
    'End Sub

    'Private Sub SetCategoryFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCategoryFileToolStripMenuItem.Click
    '    cmdProductListing_Click(0, AcceptButton)
    'End Sub

    'Private Sub SetItemFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetItemFileToolStripMenuItem.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmCatITEMList.IsHandleCreated Then
    '            .Add("Category Item List", 18)
    '        End If
    '    End With
    '    FrmCatITEMList.MdiParent = Me
    '    FrmCatITEMList.Width = Me.Width
    '    FrmCatITEMList.Height = Me.Height
    '    FrmCatITEMList.Show()
    '    'End If
    'End Sub

    'Private Sub SuppliersProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersProductToolStripMenuItem.Click
    '    If x_Access(xUser_Access) Then
    '        With lstShortCut.Items
    '            If Not FrmSUPPLIERSPRODUCT.IsHandleCreated Then
    '                .Add("Supplier Products", 19)
    '            End If
    '        End With
    '        FrmSUPPLIERSPRODUCT.MdiParent = Me
    '        FrmSUPPLIERSPRODUCT.Width = Me.Width
    '        FrmSUPPLIERSPRODUCT.Height = Me.Height
    '        FrmSUPPLIERSPRODUCT.Show()
    '    End If

    'End Sub

    'Private Sub StockOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockOrderToolStripMenuItem.Click
    '    cmdOrderReceive_Click(0, AcceptButton)
    'End Sub

    'Private Sub StockReceiveFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FrmPURCHASEORDER_RECEIVE.MdiParent = Me
    '    FrmPURCHASEORDER_RECEIVE.Width = Me.Width
    '    FrmPURCHASEORDER_RECEIVE.Height = Me.Height
    '    FrmPURCHASEORDER_RECEIVE.Show()
    'End Sub

    'Private Sub StockMonitoringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockMonitoringToolStripMenuItem.Click
    '    cmdStockMonitoring_Click(0, AcceptButton)
    'End Sub

    'Private Sub BusinessInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusinessInformationToolStripMenuItem.Click
    '    If x_Access(xUser_Access) Then
    '        FrmBUSINESS_INFO.ShowDialog()
    '    End If
    'End Sub

    'Private Sub CashieringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashieringToolStripMenuItem.Click
    '    cmdCashiering_Click(0, AcceptButton)
    'End Sub

    'Private Sub SalesReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReceiptToolStripMenuItem.Click
    '    cmdSalesReceipt_Click(0, AcceptButton)
    'End Sub

    'Private Sub SupplierProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierProfileToolStripMenuItem.Click
    '    Dim Report As New FrmREPORTS
    '    If x_Access(xUser_Access) Then
    '        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Suppliers Listing")
    '        globalFRM = "FrmSuppliersList"
    '        Rpt_SqlStr = "SELECT * FROM TBL_Suppliers ORDER BY SuppName"
    '        Report.Show()
    '        'FrmREPORTS.Show()
    '    End If
    'End Sub

    'Private Sub SupplierProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierProductsToolStripMenuItem.Click
    '    Dim Report As New FrmREPORTS
    '    If x_Access(xUser_Access) Then
    '        Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Suppliers Products")
    '        globalFRM = "frmsuppliersproduct"
    '        Rpt_SqlStr = "SELECT * FROM TBL_Suppliers ORDER BY SuppName "
    '        Report.Show()
    '        'FrmREPORTS.Show()
    '    End If

    'End Sub

    'Private Sub PurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
    '    Dim report As New FrmREPORTSDated
    '    ' If x_Access(xUser_Access) Then
    '    'Audit_Trail(xUser_ID, "Print Report - Purchase Order Stocks")
    '    globalFRM = "FrmPURCHASEORDER"
    '    'FrmREPORTSDated.MdiParent = Me
    '    'FrmREPORTSDated.Width = Me.Width
    '    'FrmREPORTSDated.Height = Me.Height
    '    report.Show()
    '    'FrmPURCHASE_ORDER_PRINT.ShowDialog()
    '    'End If
    'End Sub

    'Private Sub PurchaseReceiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReceiveToolStripMenuItem.Click
    '    Dim report As New FrmREPORTSDated
    '    ' If x_Access(xUser_Access) Then
    '    globalFRM = "frmpurchaseorder_receive"
    '    report.Show()
    '    '   FrmRECEIVE_ORDER_PRINT.ShowDialog()

    '    ' End If

    'End Sub

    'Private Sub StockBalancesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBalancesToolStripMenuItem.Click
    '    Dim Report As New FrmREPORTS
    '    'If x_Access(xUser_Access) Then
    '    Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Current Stocks Balances")
    '    globalFRM = "FrmSTOCKMONITORINGBALANCES"
    '    Rpt_SqlStr = "SELECT * FROM TBL_Stocks_Balances"
    '    Report.Show()
    '    'FrmREPORTS.Show()
    '    'End If
    'End Sub

    'Private Sub SalesCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesCollectionToolStripMenuItem.Click
    '    'FrmSALES_COLLECTION_PRINT.ShowDialog()
    '    Dim report As New FrmREPORTSDated
    '    'If x_Access(xUser_Access) Then
    '    'Audit_Trail(xUser_ID, "Print Report - Purchase Order Stocks")
    '    globalFRM = "FrmSales_Collection"
    '    'FrmREPORTSDated.MdiParent = Me
    '    'FrmREPORTSDated.Width = Me.Width
    '    'FrmREPORTSDated.Height = Me.Height
    '    report.Show()
    '    'FrmPURCHASE_ORDER_PRINT.ShowDialog()
    '    ' End If
    'End Sub

    'Private Sub SalesCollectionReportVOIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesCollectionReportVOIDToolStripMenuItem.Click
    '    'FrmSALES_COLLECTION_VOID_PRINT.ShowDialog()
    '    Dim report As New FrmREPORTSDated
    '    If x_Access(xUser_Access) Then
    '        globalFRM = "frmcollection_void"
    '        report.Show()
    '    End If
    'End Sub

    'Private Sub CollectionSummaryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectionSummaryReportToolStripMenuItem.Click
    '    'FrmCOLLECTION_SUMMARY.ShowDialog()
    '    Dim report As New FrmREPORTSDated
    '    'If x_Access(xUser_Access) Then
    '    globalFRM = "frmcollection_summary"
    '    report.Show()
    '    ' End If
    'End Sub

    'Private Sub ProductsReorderPointToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsReorderPointToolStripMenuItem1.Click
    '    Dim Report As New FrmREPORTS
    '    'If x_Access(xUser_Access) Then
    '    Audit_Trail(xUser_ID, TimeOfDay, "Print Report - Products Reorder Level")
    '    globalFRM = "FrmPRODUCTS_REORDER"
    '    Rpt_SqlStr = "SELECT * FROM TBL_Category_Item_File " & _
    '                 "WHERE Item_ID IN (SELECT Item_ID FROM TBL_Stocks_Balances WHERE Item_QTY <= Item_Reorder_Point)"
    '    Report.Show()
    '    'FrmREPORTS.Show()
    '    'End If
    'End Sub

    'Private Sub BarcodeFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarcodeFormToolStripMenuItem.Click
    '    FrmBarcode.ShowDialog()
    'End Sub

    'Private Sub UnitMeasureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitMeasureToolStripMenuItem.Click
    '    If x_Access(xUser_Access) Then
    '        FrmUNIT_MEASURE.ShowDialog()
    '    End If
    'End Sub

    'Private Sub SalesReceiptToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReceiptToolStripMenuItem1.Click
    '    'FrmSALES_REPORT_RECEIPT.ShowDialog()
    '    Dim report As New FrmREPORTSDated
    '    'If x_Access(xUser_Access) Then
    '    globalFRM = "frmsales_report_receipt"
    '    report.Show()
    '    'End If
    'End Sub

    'Private Sub toolStripClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FormClose(ActiveMdiChild)
    'End Sub

    'Private Sub ToolStripNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FormAdd(ActiveMdiChild.Name)
    'End Sub

    'Private Sub ToolStripEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FormEdit(ActiveMdiChild.Name)
    'End Sub

    'Private Sub ToolStripDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FormDelete(ActiveMdiChild.Name)
    'End Sub

    'Private Sub ToolStripSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FormSearch(ActiveMdiChild.Name)
    'End Sub

    'Private Sub ToolStripPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FormPrint(ActiveMdiChild.Name)
    'End Sub

    'Private Sub ToolStripLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FrmLOGIN.ShowDialog()
    'End Sub

    'Private Sub AuditTrailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditTrailToolStripMenuItem.Click
    '    If x_Access(xUser_Access) Then
    '        With lstShortCut.Items
    '            If Not FrmAUDIT_TRAIL.IsHandleCreated Then
    '                .Add("Users Log", 20)
    '            End If
    '        End With
    '        FrmAUDIT_TRAIL.MdiParent = Me
    '        FrmAUDIT_TRAIL.WindowState = FormWindowState.Maximized
    '        FrmAUDIT_TRAIL.Show()
    '    End If
    'End Sub

    'Private Sub ToolStripRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    RefreshList(ActiveMdiChild.Name)
    'End Sub

    'Private Sub ProductsReorderPointToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsReorderPointToolStripMenuItem.Click
    '    cmdProductReorder_Click(0, AcceptButton)
    'End Sub

    'Private Sub LinkMaintain_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkMaintain.LinkClicked
    '    Click_Maintain()
    'End Sub

    'Private Sub LinkPurchasing_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkPurchasing.LinkClicked
    '    Click_Purchasing()
    'End Sub

    'Private Sub LinkSales_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkSales.LinkClicked
    '    HMER_GENNHSEON.MdiParent = Me
    '    HMER_GENNHSEON.Height = Me.Height
    '    HMER_GENNHSEON.Width = Me.Width

    '    HMER_GENNHSEON.BringToFront()

    '    HMER_GENNHSEON.Show()
    'End Sub

    'Private Sub cmdProductListing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXOIROMHTERES.Click
    '    'ΧΟΙΡΟΜΗΤΕΡΕΣ ====================================================




    '    Dim k As Integer
    '    Dim found As Integer = 0
    '    For k = 0 To lstShortCut.Items.Count - 1
    '        If lstShortCut.Items(k).Text = "Χοιρομητέρες" Then
    '            found = 1
    '        End If
    '    Next
    '    If found = 0 Then
    '        lstShortCut.Items.Add("Χοιρομητέρες", 11)
    '    End If
    '    Proionta.MdiParent = Me
    '    Proionta.Height = Me.Height
    '    Proionta.Width = Me.Width
    '    '  Proionta.Label4.Text = "PROIONTA"
    '    GEnergh_forma = "XOIROMHTERES"
    '    gQuery = "SELECT ENOTIO,RATSA AS [ΡΑΤΣA],KATASTASHC AS [ΚΑΤΑΣΤΑΣΗ],HMEGEN AS [ΗΜ.ΓΕΝΝ] FROM XOIROMHTERES where MANES=1 ORDER BY ENOTIO"
    '    'rbcatitemlist()
    '    Proionta.rbcatitemlist.Checked = True
    '    Proionta.BackColor = Color.Blue
    '    Proionta.Label1.Text = "Χοιρομητέρες"
    '    FillListView(ExecuteSQLQuery(gQuery), Proionta.lstCat, 1)
    '    If found = 1 Then
    '        Proionta.BringToFront()
    '        Proionta.Show()
    '    Else
    '        Proionta.Show()
    '    End If





    'End Sub

    'Private Sub cmdManageSuppliers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKAPROI.Click
    '    'KAPROI ====================================================
    '    'KAPROI = New FrmCatList

    '    KAPROS.MdiParent = Me
    '    KAPROS.Height = Me.Height
    '    KAPROS.Width = Me.Width

    '    KAPROS.BringToFront()

    '    KAPROS.Show()








    '    'gQuery = "SELECT ENOTIO,RATSA AS [ΡΑΤΣA],KATASTASHC AS [ΚΑΤΑΣΤΑΣΗ],HMEGEN AS [ΗΜ.ΓΕΝΝ] FROM XOIROMHTERES where MANES=2 ORDER BY ENOTIO"

    '    'Dim k As Integer
    '    'Dim found As Integer = 0
    '    'For k = 0 To lstShortCut.Items.Count - 1
    '    '    If lstShortCut.Items(k).Text = "Κάπροι" Then
    '    '        found = 1
    '    '    End If
    '    'Next
    '    'If found = 0 Then
    '    '    lstShortCut.Items.Add("Κάπροι", 11)
    '    'End If
    '    'KAPROI.MdiParent = Me
    '    'KAPROI.Height = Me.Height
    '    'KAPROI.Width = Me.Width
    '    'KAPROI.Label1.Text = "KAPROI"
    '    'GEnergh_forma = "KAPROI"
    '    'KAPROI.RBALL.Checked = True
    '    'KAPROI.BackColor = Color.Blue
    '    'FillListView(ExecuteSQLQuery(gQuery), KAPROI.lstCat, 1)

    '    'If found = 1 Then
    '    '    KAPROI.BringToFront()
    '    '    KAPROI.Show()
    '    'Else
    '    '    KAPROI.Show()
    '    'End If

    '    ' End If
    'End Sub

    'Private Sub lstShortCut_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstShortCut.MouseDoubleClick

    '    Dim k As Integer
    '    Dim found As Integer = 0


    '    Select Case lstShortCut.FocusedItem.Text
    '        Case "Product Listing"
    '            'FrmCatList.BringToFront()
    '        Case "Α' ύλες"

    '            'For k = 0 To lstShortCut.Items.Count - 1
    '            '    If lstShortCut.Items(k).Text = "Προϊόντα" Then
    '            '        Proionta.Hide()
    '            '    End If

    '            '    If lstShortCut.Items(k).Text = "Manage Suppliers" Then
    '            '        FrmSuppliersList.Hide()
    '            '    End If
    '            'Next
    '            'globalList.Show()
    '            globalList.BringToFront()
    '        Case "Προϊόντα"

    '            'For k = 0 To lstShortCut.Items.Count - 1
    '            '    If lstShortCut.Items(k).Text = "Α' ύλες" Then
    '            '        globalList.Hide()
    '            '    End If

    '            '    If lstShortCut.Items(k).Text = "Manage Suppliers" Then
    '            '        FrmSuppliersList.Hide()
    '            '    End If
    '            'Next
    '            'Proionta.Show()
    '            Proionta.BringToFront()

    '        Case "Manage Suppliers"
    '            'For k = 0 To lstShortCut.Items.Count - 1
    '            '    If lstShortCut.Items(k).Text = "Α' ύλες" Then
    '            '        globalList.Hide()
    '            '    End If

    '            '    If lstShortCut.Items(k).Text = "Προϊόντα" Then
    '            '        Proionta.Hide()
    '            '    End If
    '            'Next
    '            'FrmSuppliersList.Show()
    '            FrmSuppliersList.BringToFront()


    '        Case "Order and Receive"
    '            FrmPURCHASEORDER.BringToFront()
    '        Case "Stock Monitoring"
    '            frmSTOCKMONITORINGBALANCES.BringToFront()
    '        Case "Critical Product(s)"
    '            FrmPRODUCTS_REORDER.BringToFront()
    '        Case "Defective Stocks"
    '            FrmDEFFECTIVE_RETURN_STOCKS.BringToFront()
    '        Case "Ordering Kiosk"
    '            FrmORDER_FORM.BringToFront()
    '        Case "Cashiering"
    '            FrmPOSCASHIER.BringToFront()
    '        Case "Sales Receipt"
    '            FrmPOSRECEIPT_LIST.BringToFront()
    '        Case "Physical Counting"
    '            FrmPhysicalCount.BringToFront()
    '        Case "Category Item List"
    '            FrmCatITEMList.BringToFront()
    '        Case "Supplier Products"
    '            FrmSUPPLIERSPRODUCT.BringToFront()
    '        Case "Users Log"
    '            FrmAUDIT_TRAIL.BringToFront()
    '    End Select
    'End Sub

    'Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsers.Click






    '    'Dim k As Integer
    '    'Dim found As Integer = 0
    '    'For k = 0 To lstShortCut.Items.Count - 1
    '    '    If lstShortCut.Items(k).Text = "Α' ύλες" Then
    '    '        found = 1
    '    '    End If
    '    'Next
    '    'If found = 0 Then
    '    '    lstShortCut.Items.Add("Α' ύλες", 2)
    '    'End If



    '    'globalList.MdiParent = Me
    '    ''Proionta.MdiParent = Me

    '    ''FrmCatList.WindowState = FormWindowState.Maximized
    '    'globalList.Height = Me.Height
    '    'globalList.Width = Me.Width
    '    '' globalList.Label4.Text = "AYLES"
    '    'GEnergh_forma = "AYLES"
    '    'globalList.RBALL.Checked = True


    '    'If found = 1 Then
    '    '    globalList.BringToFront()
    '    '    globalList.Show()
    '    'Else
    '    '    globalList.Show()
    '    'End If








    'End Sub

    'Private Sub cmdOrderReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrderReceive.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmPURCHASEORDER.IsHandleCreated Then
    '            .Add("Order and Receive", 13)
    '        End If
    '    End With
    '    FrmPURCHASEORDER.MdiParent = Me
    '    FrmPURCHASEORDER.Width = Me.Width
    '    FrmPURCHASEORDER.Height = Me.Height
    '    FrmPURCHASEORDER.Show()
    '    'End If
    'End Sub

    'Private Sub cmdStockMonitoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStockMonitoring.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not frmSTOCKMONITORINGBALANCES.IsHandleCreated Then
    '            .Add("Stock Monitoring", 3)
    '        End If
    '    End With
    '    frmSTOCKMONITORINGBALANCES.MdiParent = Me
    '    frmSTOCKMONITORINGBALANCES.Width = Me.Width
    '    frmSTOCKMONITORINGBALANCES.Height = Me.Height
    '    frmSTOCKMONITORINGBALANCES.Show()
    '    'End If
    'End Sub

    'Private Sub cmdProductReorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProductReorder.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmPRODUCTS_REORDER.IsHandleCreated Then
    '            .Add("Critical Product(s)", 14)
    '        End If
    '    End With
    '    FrmPRODUCTS_REORDER.MdiParent = Me
    '    FrmPRODUCTS_REORDER.Width = Me.Width
    '    FrmPRODUCTS_REORDER.Height = Me.Height
    '    FrmPRODUCTS_REORDER.Show()
    '    'End If
    'End Sub

    'Private Sub cmdDefective_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDefective.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmDEFFECTIVE_RETURN_STOCKS.IsHandleCreated Then
    '            .Add("Defective Stocks", 15)
    '        End If
    '    End With
    '    FrmDEFFECTIVE_RETURN_STOCKS.MdiParent = Me
    '    FrmDEFFECTIVE_RETURN_STOCKS.Width = Me.Width
    '    FrmDEFFECTIVE_RETURN_STOCKS.Height = Me.Height
    '    FrmDEFFECTIVE_RETURN_STOCKS.Show()
    '    'End If
    'End Sub

    'Private Sub cmdBusInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBusInfo.Click
    '    'If x_Access(xUser_Access) Then
    '    FrmBUSINESS_INFO.ShowDialog()
    '    ' End If
    'End Sub

    'Private Sub Click_Maintain()
    '    Dim i As Integer
    '    'LinkMaintain.Enabled = False
    '    If minMaintenance = 0 Then
    '        For i = 0 To 177
    '            PanelMaintain.Height = PanelMaintain.Height + 1
    '            PanelPurchasing.Top = PanelMaintain.Height + 20
    '            PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top)
    '            minMaintenance = minMaintenance + PanelMaintain.Height
    '            'Application.DoEvents()
    '        Next
    '    Else
    '        'MsgBox(Min)
    '        For i = 0 To 177
    '            PanelMaintain.Height = PanelMaintain.Height - 1
    '            PanelPurchasing.Top = (PanelMaintain.Height + 30) - 20
    '            PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top)
    '            'Application.DoEvents()
    '        Next
    '        minMaintenance = 0
    '    End If
    '    'LinkMaintain.Enabled = True
    'End Sub

    'Private Sub Click_Purchasing()
    '    Dim i As Integer
    '    'LinkPurchasing.Enabled = False
    '    If minPurchase = 0 Then
    '        For i = 0 To 170
    '            PanelPurchasing.Height = PanelPurchasing.Height + 1
    '            PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) + 15
    '            minPurchase = minPurchase + PanelPurchasing.Height
    '            'Application.DoEvents()
    '        Next
    '    Else
    '        'MsgBox(Min)
    '        For i = 0 To 170
    '            PanelPurchasing.Height = PanelPurchasing.Height - 1
    '            PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) - 2
    '            Application.DoEvents()
    '        Next
    '        minPurchase = 0
    '    End If
    '    'LinkPurchasing.Enabled = True
    'End Sub

    'Private Sub Click_Sales()
    '    Dim i As Integer
    '    'LinkSales.Enabled = False
    '    If minSales = 0 Then
    '        For i = 0 To 120
    '            PanelSales.Height = PanelSales.Height + 1
    '            'PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) + 15
    '            minSales = minSales + PanelPurchasing.Height
    '            ' Application.DoEvents()
    '        Next
    '    Else
    '        'MsgBox(Min)
    '        For i = 0 To 120
    '            PanelSales.Height = PanelSales.Height - 1
    '            'PanelSales.Top = (PanelPurchasing.Height + PanelPurchasing.Top) - 5
    '            Application.DoEvents()
    '        Next
    '        minSales = 0
    '    End If
    '    'LinkSales.Enabled = True
    'End Sub

    'Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    '    FormClose(ActiveMdiChild)
    'End Sub

    'Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
    '    FormAdd(GEnergh_forma) 'ActiveMdiChild.Name)
    'End Sub

    'Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    '    FormEdit(GEnergh_forma) ' ActiveMdiChild.Name)
    'End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    If xUser_Access = "οχιAdministrator" Then
    '        pnadvisory_Admin.BringToFront()
    '        pnadvisory_Admin.Visible = True
    '        pnadvisory_Admin.Left = pnadvisory_Admin.Left - 1.3
    '        If pnadvisory_Admin.Left <= (pnadvisory_Admin.Width * -1) Then
    '            pnadvisory_Admin.Left = Me.Width + 150
    '        End If
    '        'If xSlidePanel <= -10 Then
    '        ' pnadvisory_Admin.Left = Me.Width + 150
    '        'End If
    '    ElseIf xUser_Access = "Cashier" Then
    '        pnAdvisory_Cashier.BringToFront()
    '        pnAdvisory_Cashier.Visible = True
    '        pnAdvisory_Cashier.Left = pnAdvisory_Cashier.Left - 1.3
    '        If pnAdvisory_Cashier.Left <= (pnAdvisory_Cashier.Width * -1) Then
    '            pnAdvisory_Cashier.Left = Me.Width + 150
    '        End If
    '    ElseIf xUser_Access = "Stock Room" Then
    '        pnAdvisory_Stock.BringToFront()
    '        pnAdvisory_Stock.Visible = True
    '        pnAdvisory_Stock.Left = pnAdvisory_Stock.Left - 1.3
    '        If pnAdvisory_Stock.Left <= (pnAdvisory_Stock.Width * -1) Then
    '            pnAdvisory_Stock.Left = Me.Width + 150
    '        End If
    '    ElseIf xUser_Access = "Sales Agent" Then
    '        pnAdvisory_SalesAgent.BringToFront()
    '        pnAdvisory_SalesAgent.Visible = True
    '        pnAdvisory_SalesAgent.Left = pnAdvisory_SalesAgent.Left - 1.3
    '        If pnAdvisory_SalesAgent.Left <= (pnAdvisory_SalesAgent.Width * -1) Then
    '            pnAdvisory_SalesAgent.Left = Me.Width + 150
    '        End If
    '    End If
    'End Sub

    'Private Sub cmdCustomerOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomerOrder.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmORDER_FORM.IsHandleCreated Then
    '            .Add("Ordering Kiosk", 7)
    '        End If
    '    End With
    '    FrmORDER_FORM.MdiParent = Me
    '    FrmORDER_FORM.Width = Me.Width
    '    FrmORDER_FORM.Height = Me.Height
    '    FrmORDER_FORM.Show()
    '    'End If
    'End Sub


    'Private Sub cmdCashiering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashiering.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmPOSCASHIER.IsHandleCreated Then
    '            .Add("Cashiering", 17)
    '        End If
    '    End With
    '    FrmPOSCASHIER.MdiParent = Me
    '    'FrmPOSCASHIER.WindowState = FormWindowState.Maximized
    '    FrmPOSCASHIER.Width = Me.Width
    '    FrmPOSCASHIER.Height = Me.Height
    '    FrmPOSCASHIER.Show()
    '    'End If
    'End Sub

    'Private Sub MDIMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
    '    'Debug.Print("test4")
    '    ActivatedToolbar(ActiveMdiChild)
    'End Sub

    'Private Sub MDIMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    'MsgBox(1)
    '    With TSHoldRight
    '        PanelShortCut.Top = .Top - 15
    '        PanelShortCut.Left = .Left - 1
    '    End With
    '    PanelHoldAdvisory.Top = TSHoldAdvisory.Top
    '    PanelAdvisory.Top = PanelHoldAdvisory.Top
    '    PanelShortCut.Height = (Me.Height - (TSHoldButtons.Height + TSHoldAdvisory.Height + (TSHoldAdvisory.Height / 2) + 30))
    '    lstShortCut.Height = PanelShortCut.Height - 27
    'End Sub

    'Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
    '    RefreshList(GEnergh_forma) 'ActiveMdiChild.Name)
    'End Sub

    'Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
    '    FormPrint(GEnergh_forma)
    'End Sub

    'Private Sub cmdSalesReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalesReceipt.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmPOSRECEIPT_LIST.IsHandleCreated Then
    '            .Add("Sales Receipt", 16)
    '        End If
    '    End With
    '    FrmPOSRECEIPT_LIST.MdiParent = Me
    '    FrmPOSRECEIPT_LIST.WindowState = FormWindowState.Maximized
    '    'FrmORDER_FORM.Width = Me.Width
    '    'FrmORDER_FORM.Height = Me.Height
    '    FrmPOSRECEIPT_LIST.Show()
    '    'End If
    'End Sub


    'Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    '    FormDelete(GEnergh_forma) 'ActiveMdiChild.Name)
    'End Sub

    'Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
    '    FormSearch(GEnergh_forma)
    'End Sub

    'Private Sub cmdPhysical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPhysical.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmPhysicalCount.IsHandleCreated Then
    '            .Add("Physical Counting", 10)
    '        End If
    '    End With
    '    FrmPhysicalCount.MdiParent = Me
    '    'FrmPhysicalCount.WindowState = FormWindowState.Maximized
    '    FrmORDER_FORM.Width = Me.Width
    '    FrmORDER_FORM.Height = Me.Height
    '    FrmPhysicalCount.Show()
    '    'End If
    'End Sub

    'Private Sub tmrclock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrclock.Tick
    '    lbltime.Text = TimeOfDay
    'End Sub

    'Private Sub cmdAuditTrail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAuditTrail.Click
    '    'If x_Access(xUser_Access) Then
    '    With lstShortCut.Items
    '        If Not FrmAUDIT_TRAIL.IsHandleCreated Then
    '            .Add("Users Log", 20)
    '        End If
    '    End With
    '    ' frmSTOCKMONITORINGBALANCES.MdiParent = Me
    '    ' frmSTOCKMONITORINGBALANCES.Width = Me.Width
    '    ' frmSTOCKMONITORINGBALANCES.Height = Me.Height
    '    ' frmSTOCKMONITORINGBALANCES.Show()

    '    FrmAUDIT_TRAIL.MdiParent = Me
    '    FrmAUDIT_TRAIL.Width = Me.Width
    '    FrmAUDIT_TRAIL.Height = Me.Height
    '    FrmAUDIT_TRAIL.Show()
    '    'End If
    'End Sub

    'Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
    '    xclose()
    '    lstShortCut.Items.Clear()
    '    sqlSTR = "UPDATE TBL_Audit_Log SET LOGOUT ='" & TimeOfDay & "' WHERE User_ID =" & xUser_ID & " AND LOG_ID=" & LOGID
    '    ExecuteSQLQuery(sqlSTR)
    '    LinkMaintain.Enabled = False
    '    LinkPurchasing.Enabled = False
    '    LinkSales.Enabled = False
    '    'Maintenance
    '    cmdXOIROMHTERES.Enabled = False
    '    cmdKAPROI.Enabled = False
    '    cmdUsers.Enabled = False
    '    cmdAuditTrail.Enabled = False
    '    cmdBusInfo.Enabled = False
    '    'Purchasing
    '    cmdOrderReceive.Enabled = False
    '    cmdStockMonitoring.Enabled = False
    '    cmdPhysical.Enabled = False
    '    cmdProductReorder.Enabled = False
    '    cmdDefective.Enabled = False
    '    'Sales
    '    cmdCustomerOrder.Enabled = False
    '    cmdCashiering.Enabled = False
    '    cmdSalesReceipt.Enabled = False
    '    Timer1.Enabled = False
    '    pnadvisory_Admin.Visible = False
    '    pnAdvisory_Stock.Visible = False
    '    pnAdvisory_Cashier.Visible = False
    '    pnAdvisory_SalesAgent.Visible = False
    '    tmrcritical.Enabled = False
    '    FrmLOGIN.ShowDialog()
    'End Sub

    'Public Function aget()

    '    If UCase(xUser_Access) = UCase("Administrator") Then
    '        LinkMaintain.Enabled = True
    '        LinkPurchasing.Enabled = True
    '        LinkSales.Enabled = True
    '        'Maintenance
    '        cmdXOIROMHTERES.Enabled = True
    '        cmdKAPROI.Enabled = True
    '        cmdUsers.Enabled = True
    '        cmdAuditTrail.Enabled = True
    '        cmdBusInfo.Enabled = True
    '        'Purchasing
    '        cmdOrderReceive.Enabled = True
    '        cmdStockMonitoring.Enabled = True
    '        cmdPhysical.Enabled = True
    '        cmdProductReorder.Enabled = True
    '        cmdDefective.Enabled = True
    '        'Sales
    '        cmdCustomerOrder.Enabled = True
    '        cmdCashiering.Enabled = True
    '        cmdSalesReceipt.Enabled = True
    '    ElseIf UCase(xUser_Access) = UCase("Cashier") Then
    '        'Maintenance
    '        cmdXOIROMHTERES.Enabled = False
    '        cmdKAPROI.Enabled = False
    '        cmdUsers.Enabled = True
    '        cmdAuditTrail.Enabled = False
    '        cmdBusInfo.Enabled = False
    '        'Purchasing
    '        cmdOrderReceive.Enabled = False
    '        cmdStockMonitoring.Enabled = False
    '        cmdPhysical.Enabled = False
    '        cmdProductReorder.Enabled = False
    '        cmdDefective.Enabled = False
    '        'Sales
    '        cmdCustomerOrder.Enabled = False
    '        cmdCashiering.Enabled = True
    '        cmdSalesReceipt.Enabled = True

    '        LinkMaintain.Enabled = False
    '        LinkPurchasing.Enabled = False
    '        LinkSales.Enabled = True

    '    ElseIf UCase(xUser_Access) = UCase("Stock Room") Then
    '        'Maintenance
    '        cmdXOIROMHTERES.Enabled = False
    '        cmdKAPROI.Enabled = False
    '        cmdUsers.Enabled = True
    '        cmdAuditTrail.Enabled = False
    '        cmdBusInfo.Enabled = False
    '        'Purchasing
    '        cmdOrderReceive.Enabled = True
    '        cmdStockMonitoring.Enabled = True
    '        cmdPhysical.Enabled = True
    '        cmdProductReorder.Enabled = True
    '        cmdDefective.Enabled = True
    '        'Sales
    '        cmdCustomerOrder.Enabled = False
    '        cmdCashiering.Enabled = False
    '        cmdSalesReceipt.Enabled = False

    '        LinkMaintain.Enabled = False
    '        LinkPurchasing.Enabled = True
    '        LinkSales.Enabled = False
    '    ElseIf UCase(xUser_Access) = UCase("Sales Agent") Then
    '        'Maintenance
    '        cmdXOIROMHTERES.Enabled = True
    '        cmdKAPROI.Enabled = True
    '        cmdUsers.Enabled = True
    '        cmdAuditTrail.Enabled = False
    '        cmdBusInfo.Enabled = False
    '        'Purchasing
    '        cmdOrderReceive.Enabled = True
    '        cmdStockMonitoring.Enabled = True
    '        cmdPhysical.Enabled = True
    '        cmdProductReorder.Enabled = True
    '        cmdDefective.Enabled = True
    '        'Sales
    '        cmdCustomerOrder.Enabled = True
    '        cmdCashiering.Enabled = False
    '        cmdSalesReceipt.Enabled = False

    '        LinkMaintain.Enabled = True
    '        LinkPurchasing.Enabled = True
    '        LinkSales.Enabled = True
    '    End If
    '    aget = 0
    'End Function

    'Private Sub cmdHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHome.Click
    '    FrmBG.BringToFront()
    'End Sub

    'Private Sub lstShortCut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstShortCut.SelectedIndexChanged

    'End Sub

    'Private Sub pnadvisory_Admin_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnadvisory_Admin.Paint

    'End Sub

    'Private Sub tmrcritical_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrcritical.Tick
    '    critical = critical + 1

    '    If (critical Mod 2) = 0 Then
    '        ' MsgBox(critical & "   1")
    '        'cmdProductReorder.Enabled = False
    '        cmdProductReorder.ForeColor = Color.Red
    '    Else
    '        cmdProductReorder.ForeColor = Color.Black
    '        'MsgBox(critical & "  2")
    '        'cmdProductReorder.Enabled = True
    '    End If
    'End Sub

    'Private Sub ProductPacingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductPacingReportToolStripMenuItem.Click
    '    'Dim report As New FrmREPORTSDated
    '    ' If x_Access(xUser_Access) Then
    '    'Audit_Trail(xUser_ID, "Print Report - Purchase Order Stocks")
    '    'globalFRM = "frmproduct_pacing"
    '    'FrmREPORTSDated.MdiParent = Me
    '    'FrmREPORTSDated.Width = Me.Width
    '    'FrmREPORTSDated.Height = Me.Height
    '    'report.Show()
    '    'FrmPURCHASE_ORDER_PRINT.ShowDialog()
    '    ' End If
    'End Sub

    'Private Sub tmr_Print_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Print.Tick
    '    i_Print += 1
    '    If i_Print = 1 Then
    '        lblprint.Text = "Please wait while printing records."
    '    ElseIf i_Print = 2 Then
    '        lblprint.Text = "Please wait while printing records.."
    '    ElseIf i_Print = 3 Then
    '        lblprint.Text = "Please wait while printing records..."
    '    ElseIf i_Print = 4 Then
    '        lblprint.Text = "Please wait while printing records...."
    '        i_Print = 0
    '    End If
    'End Sub

    'Private Sub FastMovingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FastMovingToolStripMenuItem.Click
    '    Dim report As New FrmREPORTSDated
    '    globalFRM = "frmproduct_pacing_fast_moving"
    '    report.Show()
    'End Sub

    'Private Sub SlowMovingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlowMovingToolStripMenuItem.Click
    '    Dim report As New FrmREPORTSDated
    '    globalFRM = "frmproduct_pacing_slow_moving"
    '    report.Show()
    'End Sub

    'Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
    '    'MsgBox(Application.StartupPath)
    '    System.Diagnostics.Process.Start(Application.StartupPath & "\Gazuto Manual.doc")
    'End Sub

    'Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
    '    'FrmAbout.ShowDialog()
    'End Sub

    'Private Sub lblprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblprint.Click

    'End Sub

    'Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    'End Sub

    'Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    'End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' gConnect = "Data Source=localhost\SQLEXPRESS;Integrated Security=True;database=SaleInv_DB"
        'If username = "" Then
        ' End
        ' End If
        'xUser_Access = "Administrator"
        checkServer()
        FrmLOGIN.ShowDialog()

        Dim K As Integer
        'ExecuteSQLQuery("DELETE FROM THESEIS")
        'For K = 1 To 150
        '    ExecuteSQLQuery("INSERT INTO THESEIS (N1,N2) VALUES (" + Str(K) + ",1)")
        '    ExecuteSQLQuery("INSERT INTO THESEIS (N1,N2) VALUES (" + Str(K) + ",2)")
        '  Next


    End Sub







    Private Sub cmdERGATES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdERGATES.Click
        gergates.Text = "Αρχείο Εργασιών"
        gergates.Label1.Text = "SELECT NAME AS [Ονοματεπώνυμο],ENERGOS AS [ENERGOS],ID FROM ERGATES " ' ORDER BY HME "
        gergates.STHLHTOY_ID = 2
        gergates.MdiParent = Me
        gergates.WindowState = FormWindowState.Maximized




        gergates.Show()
    End Sub

    Private Sub cmdERGASIES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdERGASIES.Click
        gergates.Text = "Χρήστες"
        gergates.Label1.Text = "SELECT [Username],[UserPass],User_ID FROM TBL_Users" ' "SELECT NAME AS [Περιγραφή],ENERGOS AS [ΕΝΕΡΓΗ],SEIRES AS [ΕΧΕΙ ΣΕΙΡΕΣ],ID FROM CERGASIES " ' ORDER BY HME "

        gergates.MdiParent = Me
        gergates.WindowState = FormWindowState.Maximized
        gergates.STHLHTOY_ID = 2
        ' ergates.GridView1.Columns(2).Width = 100
        ' GridView1.Columns(colMOYMIES).Width = 40 'MOYMIES
        gergates.GridView1.AllowUserToAddRows = False
        gergates.Show()


        Exit Sub


        Dim THESEIS As New DataTable

        ExecuteSQLQuery("SELECT * FROM CERGASIES WHERE ID NOT IN (SELECT DISTINCT IDERGASIAS FROM JOBDETAIL)")
        Dim N As Integer
        Dim M3 As Integer

        For N = 0 To sqlDT.Rows.Count - 1

            M3 = sqlDT.Rows(N)("ID") 'sqlDT.Rows(0)("ID")



            ExecuteSQLQuery("SELECT * FROM THESEIS ", THESEIS)
            'M3 = sqlDT.Rows(0)(0) 'sqlDT.Rows(0)("ID")

            Dim NN As Integer = THESEIS.Rows.Count
            Dim TH(300, 2) As Integer

            For K = 0 To NN - 1
                TH(K, 1) = THESEIS.Rows(K)("N1")
                TH(K, 2) = THESEIS.Rows(K)("N2")
            Next
            Dim N1 As Integer, N2 As Integer
            For K = 0 To NN - 1
                N1 = THESEIS.Rows(K)("N1")
                N2 = THESEIS.Rows(K)("N2")
                'OK DOYLEYEI KAI ETSI   ExecuteSQLQuery("INSERT INTO JOBS (IDCERGASIA,N1,N2) VALUES(" + Str(M3) + "," + Str(TH(K, 1)) + "," + Str(TH(K, 2)) + ")")
                ExecuteSQLQuery("INSERT INTO JOBDETAIL (IDERGASIAS,N1,N2,IDERGATH) VALUES(" + Str(M3) + "," + Str(N1) + "," + Str(N2) + ",0)")
            Next
        Next



        'MsgBox("ΔΗΜΙΟΥΡΓΗΘΗΚΕ ΤΟ ΑΡΧΕΙΟ ΤΩΝ ΕΡΓΑΣΙΩΝ")












    End Sub

    Private Sub cmdCustomerOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomerOrder.Click
        SynoloOres.f_othonia = 1
        SynoloOres.Show()

    End Sub

    Private Sub jobs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toexcel.Click
        'FormJobs.MdiParent = Me
        ' FormJobs.WindowState = FormWindowState.Maximized
        'FormJobs.Show()

        Dim filename As String = "c:\mercvb\ektyp4.xlsx"
        Dim row, column As Integer
        Dim sheetname As String = "Φύλλο1"


        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xl As Excel.Worksheet

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add   'Open(filename)

        'xlWorkBook.Worksheets.Add()  '(1)
        '  xl = xlWorkBook.Worksheets(1) ' .Add







        'ελεγχω αν υπάρχει το TEMP
        ExecuteSQLQuery("IF OBJECT_ID('dbo.TEMP', 'U') IS NOT NULL  DROP TABLE dbo.TEMP")
        ''ΑΠΟΘΗΚΕΥΩ ΤΙΣ ΣΟΥΜΕΣ ΣΤΟ ΤΕΜΡ GROUP BY IDERGATH,APO,ERGATES.NAME,IDERGASIAS"
        ExecuteSQLQuery("select SUM(KILA) AS SKILA,SUM(ORES) AS SORES,SUM(METRA) AS SMETRA,IDERGATH,APO,IDERGASIAS,ERGATES.NAME,0 AS OMADA,'  ' AS COMADA INTO TEMP from JOBDETAIL INNER JOIN ERGATES ON ERGATES.ID=JOBDETAIL.IDERGATH GROUP BY IDERGATH,APO,ERGATES.NAME,IDERGASIAS")
        '        ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN SORES > 0 THEN SORES ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")


        'ΒΑΖΩ ΣΤΗΝ ΘΕΣΗ ΤΗΣ ΕΡΓΑΣΙΑΣ ΤΗΝ ΟΜΑΔΑ
        ExecuteSQLQuery("UPDATE TEMP SET OMADA=(SELECT TOP 1  N1  FROM  JOBS WHERE JOBS.ID=IDERGASIAS)")
        ExecuteSQLQuery("UPDATE TEMP SET IDERGASIAS=OMADA")



        xlApp.Visible = True


        'CREATE TABLE [dbo].[OMADES](
        '	[ID2] [int] NULL,
        '	[SEIRES] [bit] NULL,
        '	[NAME] [nvarchar](50) NULL,
        '	[ID] [int] IDENTITY(1,1) NOT NULL
        ') ON [PRIMARY]
        '        ID2	SEIRES	NAME	ID
        '1	0	ΑΠΟΦΥΛΛΩΣΗ	1
        '2	0	ΚΛΙΠΑΡΙΣΜΑ	3
        '3	1	ΣΥΓΚΟΜΙΔΗ	4
        '5	0	ΣΑΠΟΡΤ	8
        '6	0	ΛΑΙΜΑΡΓΑ	9
        '7	0	ΚΑΤΕΒΑΣΜΑ	10
        '8	0	ΛΟΙΠΕΣ ΕΡΓΑΣΙΕΣ	11
        '9	0	ΜΕΙΩΣΗ ΤΟΜΑΤΑΣ	12

        Dim metr As New DataTable


        Dim jt As New DataTable



        ' DEBUG NEXT LINE
        'ελεγχω αν υπάρχει το TEMP
        ExecuteSQLQuery("IF OBJECT_ID('dbo.TEMP1', 'U') IS NOT NULL  DROP TABLE dbo.TEMP1")
        ExecuteSQLQuery("select  distinct ID,SEIRES, NAME   INTO TEMP1 from OMADES", jt)


        ExecuteSQLQuery("select  distinct ID2 AS ID,SEIRES, NAME  from OMADES WHERE ID2 IN (SELECT IDERGASIAS FROM TEMP)", jt)


        'ExecuteSQLQuery("select  distinct N1 as ID,SEIRES,C1 AS NAME  from JOBS  WHERE N1>0 AND N1 IN (SELECT IDERGASIAS FROM TEMP)", jt)


        'Dim THESEIS As New DataTable

        Dim dt As New DataTable
        ExecuteSQLQuery("select * from ERGATES", dt)
        Dim kerg As Integer


        'ExecuteSQLQuery("select SUM(ORES) AS [ΣΥΝ.ΩΡΕΣ],SUM(METRA) AS [ΣΥΝ.ΜΕΤ],IDERGATH,DAY(HME),MONTH(HME),ERGATES.NAME from JOBDETAIL INNER JOIN ERGATES ON ERGATES.ID=JOBDETAIL.IDERGATH GROUP BY IDERGATH,DAY(HME),MONTH(HME),ERGATES.NAME", dt)
        Dim COLS As Integer


        Dim WS(30) As Microsoft.Office.Interop.Excel.Worksheet

        For k = jt.Rows.Count - 1 To 0 Step -1
            WS(k) = xlWorkBook.Worksheets.Add()




            'ψαχνω να δω μηπως υπαρχει δευτερη φορα το ονομα του φυλλου και αν υπαρχει προσθετω το str(k)
            Dim found As Integer = 0
            For row = jt.Rows.Count - 1 To k Step -1
                If WS(row).Name = jt.Rows(k)("name") Then
                    WS(k).Name = Str(k) + jt.Rows(k)("name")
                    found = 1
                End If
            Next
            If found = 0 Then
                WS(k).Name = jt.Rows(k)("name")
            End If



            ' WS(k).Name = Str(k) + jt.Rows(k)("name")
            xl = xlWorkBook.Worksheets(1)

            'xl.Columns(1).Select()
            'xl.Columns.ColumnWidth = 2

            'xl.Columns(3).Select()
            'xl.Columns.ColumnWidth = 2


            ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN IDERGASIAS=" + Str(jt.Rows(k)("ID")) + " AND SORES>0 THEN ROUND(SORES,2) ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")
            'ΕΠΙΚΕΦΑΛΙΔΕΣ ΟΝΟΜΑΤΑ ΠΕΔΙΩΝ
            For COLS = 0 To sqlDT.Columns.Count - 1
                xl.Cells(1, 2 * (COLS + 1)).value = sqlDT.Columns(COLS).ColumnName
            Next



            'ΩΡΕΣ
            For kerg = 0 To sqlDT.Rows.Count - 1
                xl.Columns(kerg + 2).Select()
                xl.Columns.AutoFit()
                '  xl.Columns.ColumnWidth = 12

                For COLS = 0 To sqlDT.Columns.Count - 1
                    xl.Cells(kerg + 2, 2 * (COLS + 1)).value = sqlDT.Rows(kerg)(COLS)
                Next
            Next



            If IsDBNull(jt.Rows(k)("seires")) Then
                ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN IDERGASIAS=" + Str(jt.Rows(k)("ID")) + " AND SMETRA>0 THEN SMETRA ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")
            Else
                If jt.Rows(k)("seires") = True Then 'kila
                    ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN IDERGASIAS=" + Str(jt.Rows(k)("ID")) + " AND SKILA>0 THEN ROUND(SKILA,2) ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")
                Else
                    ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN IDERGASIAS=" + Str(jt.Rows(k)("ID")) + " AND SMETRA>0 THEN SMETRA ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")
                End If
            End If


            'metra
            For kerg = 0 To sqlDT.Rows.Count - 1
                'xl.

                For COLS = 1 To sqlDT.Columns.Count - 1
                    xl.Cells(kerg + 2, 1 + 2 * (COLS + 1)).value = sqlDT.Rows(kerg)(COLS)
                    xl.Range(CL2(1 + 2 * (COLS + 1)) + ":" + CL2(1 + 2 * (COLS + 1))).HorizontalAlignment = -4131 'LEFT
                Next
            Next


            'xl.Columns("A:A").Select()


            xl.Range("A:A").ColumnWidth = 2
            xl.Range("C:C").ColumnWidth = 2

            'xl.Columns("C:C").Select()
            'xl.Columns.ColumnWidth = 2
            ' xl.Range("D:E").HorizontalAlignment = -4131 'LEFT

        Next
        dt = Nothing
        xlApp.Visible = True
        dt = Nothing
        mreleaseObject(xlApp)
        mreleaseObject(xlWorkBook)
        mreleaseObject(xl)

    End Sub
    Private Sub ListaErgasion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaErgasion.Click
        gergates.Text = "Αρχείο Εργασιών"
        gergates.Label1.Text = "SELECT NAME AS [Περιγραφή],ENERGOS AS [ΕΝΕΡΓΗ],SEIRES AS [ΣΕ ΚΙΛΑ],N1 AS [ID ΟΜΑΔΟΠΟΙΗΣΗΣ],C1 AS [ΠΕΡΙΓ.ΟΜΑΔ],ID AS TAYT,ID FROM JOBS " ' ORDER BY HME "
        Dim W As Integer = 950
        gergates.Width = W
        gergates.GroupBox1.Width = W - 20
        gergates.GridView1.Width = W - 20



        gergates.STHLHTOY_ID = 5
        gergates.cmdCancel.Width = 100
        gergates.cmdCancel.Left = W - gergates.cmdCancel.Width - 20

        ' ergates.MdiParent = Me
        gergates.WindowState = FormWindowState.Maximized



        gergates.ShowDialog()

        ExecuteSQLQuery("UPDATE  JOBS SET SEIRES=0 WHERE SEIRES IS NULL")

        create_detail()




    End Sub

    Sub create_detail()
        ' ExecuteSQLQuery("SELECT * FROM THESEIS")
        '  Dim M As Integer, M2 As Integer
        ' M = CERGASIES.SelectedIndex
        '  M2 = iderg(M)
        ' Dim myDate As Date = APO
        'MsgBox(Format(myDate, "MMddyy"))
        'MsgBox(myDate.ToString("MMddyy"))

        Dim jobS As New DataTable

        Dim M3 As Integer
        Dim K As Integer
        Dim METRA As Integer

        ExecuteSQLQuery("SELECT * FROM JOBS where ENERGOS=1  and ID NOT IN(SELECT IDERGASIAS FROM JOBDETAIL) ", jobS)
        Dim n As Integer

        For n = 0 To jobS.Rows.Count - 1
            M3 = jobS.Rows(n)("id") 'sqlDT.Rows(0)("ID")


            Dim THESEIS As New DataTable
            ExecuteSQLQuery("SELECT * FROM THESEIS ", THESEIS)

            Dim NN As Integer = THESEIS.Rows.Count
            Dim TH(300, 2) As Integer

            For K = 0 To NN - 1
                TH(K, 1) = THESEIS.Rows(K)("N1")
                TH(K, 2) = THESEIS.Rows(K)("N2")
            Next

            Dim N1 As Integer, N2 As Integer
            For K = 0 To NN - 1
                N1 = THESEIS.Rows(K)("N1")
                N2 = THESEIS.Rows(K)("N2")
                'OK DOYLEYEI KAI ETSI   ExecuteSQLQuery("INSERT INTO JOBS (IDCERGASIA,N1,N2) VALUES(" + Str(M3) + "," + Str(TH(K, 1)) + "," + Str(TH(K, 2)) + ")")

                'μονές σειρές είναι μήκους 65 μέτρων και οι ζυγές 70
                If N1 Mod 2 = 0 Then
                    METRA = 70
                Else
                    METRA = 65
                End If

                If IsDBNull(jobS.Rows(0)("SEIRES")) Then
                Else
                    If IsDBNull(jobS.Rows(0)("SEIRES")) = True Then ' ME KILA
                        METRA = 0
                    End If
                End If


                ExecuteSQLQuery("INSERT INTO JOBDETAIL (IDERGASIAS,N1,N2,METRA,IDERGATH) VALUES(" + Str(M3) + "," + Str(N1) + "," + Str(N2) + "," + Str(METRA) + ",0)")
            Next

        Next


        MsgBox("ΔΗΜΙΟΥΡΓΗΘΗΚΕ ΤΟ ΑΡΧΕΙΟ ΤΩΝ ΕΡΓΑΣΙΩΝ")
    End Sub

    Private Sub cmdCashiering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excelanal.Click
        'σουμα ωρων ανα εργαζομενο και ημερα
        Dim filename As String = "c:\mercvb\ektyp4.xlsx"
        Dim row, column As Integer
        Dim sheetname As String = "Φύλλο1"


        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xl As Excel.Worksheet

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add   'Open(filename)

        'xlWorkBook.Worksheets.Add()  '(1)
        xl = xlWorkBook.Worksheets(1) ' .Add





        Dim jt As New DataTable

        'ελεγχω αν υπάρχει το TEMP
        ExecuteSQLQuery("IF OBJECT_ID('dbo.TEMP', 'U') IS NOT NULL  DROP TABLE dbo.TEMP")
        ''ΑΠΟΘΗΚΕΥΩ ΤΙΣ ΣΟΥΜΕΣ ΣΤΟ ΤΕΜΡ GROUP BY IDERGATH,APO,ERGATES.NAME,IDERGASIAS"
        ExecuteSQLQuery("select APO,ERGATES.NAME,ROUND(SUM(ORES),2) AS [ΩΡΕΣ] ,IDERGATH from JOBDETAIL INNER JOIN ERGATES ON ERGATES.ID=JOBDETAIL.IDERGATH GROUP BY IDERGATH,APO,ERGATES.NAME ORDER BY APO DESC,ERGATES.NAME", jt)
        '        ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN SORES > 0 THEN SORES ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")





        xlApp.Visible = True



       

        'ExecuteSQLQuery("select SUM(ORES) AS [ΣΥΝ.ΩΡΕΣ],SUM(METRA) AS [ΣΥΝ.ΜΕΤ],IDERGATH,DAY(HME),MONTH(HME),ERGATES.NAME from JOBDETAIL INNER JOIN ERGATES ON ERGATES.ID=JOBDETAIL.IDERGATH GROUP BY IDERGATH,DAY(HME),MONTH(HME),ERGATES.NAME", dt)
        Dim COLS As Integer


        '  Dim WS(30) As Microsoft.Office.Interop.Excel.Worksheet
        Dim n As Integer
        xl.Cells(1, 1).value = "ΗΜΕΡ/ΝΙΑ"
        xl.Cells(1, 2).value = "ΟΝΟΜΑ"
        xl.Cells(1, 3).value = "ΩΡΕΣ"

        For k = 1 To jt.Rows.Count - 1
            For n = 0 To jt.Columns.Count - 2
                Try
                    xl.Cells(k + 1, n + 1).value = jt.Rows(k - 1)(n)
                Catch ex As Exception

                End Try

            Next
            Me.Text = k

        Next
        jt = Nothing
        xl.Columns.AutoFit()
        xlApp.Visible = True






        mreleaseObject(xlApp)
        mreleaseObject(xlWorkBook)
        mreleaseObject(xl)
    End Sub

    Private Function CL2(ByVal x As Integer) As String
        If x >= 1 And x <= 26 Then
            CL2 = Chr(x + 64)
        Else
            CL2 = CL2((x - x Mod 26) / 26) & Chr((x Mod 26) + 1 + 64)
        End If
    End Function

    Private Sub analytikoExcel() ' cmdCashiering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excelanal.Click
        'αναλυτικα κατα εργασια
        Dim filename As String = "c:\mercvb\ektyp4.xlsx"
        Dim row, column As Integer
        Dim sheetname As String = "Φύλλο1"


        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xl As Excel.Worksheet

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add   'Open(filename)

        'xlWorkBook.Worksheets.Add()  '(1)
        '  xl = xlWorkBook.Worksheets(1) ' .Add







        'ελεγχω αν υπάρχει το TEMP
        ExecuteSQLQuery("IF OBJECT_ID('dbo.TEMP', 'U') IS NOT NULL  DROP TABLE dbo.TEMP")
        ''ΑΠΟΘΗΚΕΥΩ ΤΙΣ ΣΟΥΜΕΣ ΣΤΟ ΤΕΜΡ GROUP BY IDERGATH,APO,ERGATES.NAME,IDERGASIAS"
        ExecuteSQLQuery("select SUM(KILA) AS SKILA,SUM(ORES) AS SORES,SUM(METRA) AS SMETRA,IDERGATH,APO,IDERGASIAS,ERGATES.NAME INTO TEMP from JOBDETAIL INNER JOIN ERGATES ON ERGATES.ID=JOBDETAIL.IDERGATH GROUP BY IDERGATH,APO,ERGATES.NAME,IDERGASIAS")
        '        ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN SORES > 0 THEN SORES ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")





        xlApp.Visible = True



        Dim metr As New DataTable


        Dim jt As New DataTable
        ExecuteSQLQuery("select * from JOBS WHERE NOT NAME IS NULL", jt)
        'Dim THESEIS As New DataTable

        Dim dt As New DataTable
        ExecuteSQLQuery("select * from ERGATES", dt)
        Dim kerg As Integer


        'ExecuteSQLQuery("select SUM(ORES) AS [ΣΥΝ.ΩΡΕΣ],SUM(METRA) AS [ΣΥΝ.ΜΕΤ],IDERGATH,DAY(HME),MONTH(HME),ERGATES.NAME from JOBDETAIL INNER JOIN ERGATES ON ERGATES.ID=JOBDETAIL.IDERGATH GROUP BY IDERGATH,DAY(HME),MONTH(HME),ERGATES.NAME", dt)
        Dim COLS As Integer


        Dim WS(300) As Microsoft.Office.Interop.Excel.Worksheet

        For k = jt.Rows.Count - 1 To 0 Step -1
            WS(k) = xlWorkBook.Worksheets.Add()
            WS(k).Name = jt.Rows(k)("name")
            xl = xlWorkBook.Worksheets(1)

            'xl.Columns(1).Select()
            'xl.Columns.ColumnWidth = 2

            'xl.Columns(3).Select()
            'xl.Columns.ColumnWidth = 2


            ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN IDERGASIAS=" + Str(jt.Rows(k)("ID")) + " AND SORES>0 THEN ROUND(SORES,2) ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")
            'ΕΠΙΚΕΦΑΛΙΔΕΣ ΟΝΟΜΑΤΑ ΠΕΔΙΩΝ
            For COLS = 0 To sqlDT.Columns.Count - 1
                xl.Cells(1, 2 * (COLS + 1)).value = sqlDT.Columns(COLS).ColumnName
            Next



            'ΩΡΕΣ
            For kerg = 0 To sqlDT.Rows.Count - 1
                xl.Columns(kerg + 2).Select()
                xl.Columns.AutoFit()
                '  xl.Columns.ColumnWidth = 12

                For COLS = 0 To sqlDT.Columns.Count - 1
                    xl.Cells(kerg + 2, 2 * (COLS + 1)).value = sqlDT.Rows(kerg)(COLS)
                Next
            Next



            If IsDBNull(jt.Rows(k)("seires")) Then
                ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN IDERGASIAS=" + Str(jt.Rows(k)("ID")) + " AND SMETRA>0 THEN SMETRA ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")
            Else
                If jt.Rows(k)("seires") = True Then 'kila
                    ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN IDERGASIAS=" + Str(jt.Rows(k)("ID")) + " AND SKILA>0 THEN ROUND(SKILA,2) ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")
                Else
                    ExecuteSQLQuery("DECLARE @cols AS NVARCHAR(MAX);DECLARE @query AS NVARCHAR(MAX); SELECT @cols = STUFF((SELECT distinct  ',' + QUOTENAME(NAME) FROM ERGATES WHERE ENERGOS=1 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'');SET @query =  'SELECT * FROM (  SELECT  ( CASE WHEN IDERGASIAS=" + Str(jt.Rows(k)("ID")) + " AND SMETRA>0 THEN SMETRA ELSE 0   END) AS Expr1,NAME,APO FROM TEMP ) t  PIVOT (SUM(Expr1) FOR NAME  IN('+  @cols+'  ) ) p;';Execute(@query);")
                End If
            End If


            'metra
            For kerg = 0 To sqlDT.Rows.Count - 1
                'xl.

                For COLS = 1 To sqlDT.Columns.Count - 1
                    xl.Cells(kerg + 2, 1 + 2 * (COLS + 1)).value = sqlDT.Rows(kerg)(COLS)
                    xl.Range(CL2(1 + 2 * (COLS + 1)) + ":" + CL2(1 + 2 * (COLS + 1))).HorizontalAlignment = -4131 'LEFT
                Next
            Next


            'xl.Columns("A:A").Select()


            xl.Range("A:A").ColumnWidth = 2
            xl.Range("C:C").ColumnWidth = 2

            'xl.Columns("C:C").Select()
            'xl.Columns.ColumnWidth = 2
            ' xl.Range("D:E").HorizontalAlignment = -4131 'LEFT






        Next
        dt = Nothing
        xlApp.Visible = True




        dt = Nothing


        mreleaseObject(xlApp)
        mreleaseObject(xlWorkBook)
        mreleaseObject(xl)
    End Sub








    Private Sub cmdSalesReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalesReceipt.Click


        Dim ans As Integer
        ans = MsgBox("Να διαγραφούν οι βάσεις;", MsgBoxStyle.YesNo)

        If ans = MsgBoxResult.Yes Then

            ExecuteSQLQuery("delete FROM JOBDETAIL")
            ExecuteSQLQuery("delete FROM DETAIL")



        End If


        'Dim filename As String = "c:\mercvb\ektyp2.xlsx"
        'Dim row, column As Integer
        'Dim sheetname As String = "Φύλλο1"


        'Dim xlApp As Excel.Application
        'Dim xlWorkBook As Excel.Workbook
        'Dim xl As Excel.Worksheet

        'xlApp = New Excel.ApplicationClass
        'xlWorkBook = xlApp.Workbooks.Open(filename)
        'xlWorkBook.Worksheets.Add()  '(1)
        'xlWorkBook.Worksheets.Add()
        'xlWorkBook.Worksheets.Add()
        'xlWorkBook.Worksheets.Add()
        'xlWorkBook.Worksheets.Add()

        'xl = xlWorkBook.Worksheets(1) ' .Add


        'xlApp.Visible = True

        'xl.Name = "apofylosi"



        'xl = xlWorkBook.Worksheets(2) ' .Add
        'xl.Name = "aaaa"


        ''  xlWorkBook.Close()
        '' xlApp.Quit()

        'mreleaseObject(xlApp)
        'mreleaseObject(xlWorkBook)
        'mreleaseObject(xl)







    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SynoloOres.f_othonia = 2
        SynoloOres.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SynoloOres.f_othonia = 3
        SynoloOres.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SynoloOres.f_othonia = 4
        SynoloOres.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        ' BOHU82.SHOW
        '<EhHeader>
        ' On Error GoTo Command16_Click_Err

        '</EhHeader>
        ' Dim k

        Dim C As String = "C:\MERCVB\THERMO.BAK"

100:    C = InputBox("ΔΩΣΕ ΟΝΟΜΑ BACKUP ΤΗΣ ΒΑΣΗΣ THERMO ΣΤΟ C:\MERCVB\THERMO.bak", , C)
110:    ExecuteSQLQuery("BACKUP DATABASE [thermo] TO  DISK ='" + C + "' WITH NOFORMAT, NOINIT, SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
120:    MsgBox("ΟΛΟΚΛΗΡΩΘΗΚΕ")

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        analytikoExcel()
    End Sub
End Class
