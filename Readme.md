<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1181)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebApplication3/Default.aspx) (VB: [Default.aspx](./VB/WebApplication3/Default.aspx))
* [Default.aspx.cs](./CS/WebApplication3/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebApplication3/Default.aspx.vb))
<!-- default file list end -->
# How to create the "select all" check box dynamically
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1181/)**
<!-- run online end -->


<p><strong>UPDATED:</strong><br /><br />Starting with version v2014 vol 1 (v14.1), this functionality is available out of the box:<br /><a href="https://www.devexpress.com/Support/Center/p/S173621">S173621: ASPxGridView - Add the built-in SelectAll CheckBox for Command Column</a><br /><br />Simply set the <strong>GridViewCommandColumn.SelectAllCheckboxMode</strong> property to <strong>GridViewSelectAllCheckBoxMode.AllPages</strong> to activate it. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2014/05/28/asp-net-gridview-select-all-rows-updated-coming-soon-in-v14-1.aspx">ASP.NET: GridView Select All Rows Updated</a> blog post and the <a href="http://demos.devexpress.com/ASPxGridViewDemos/Selection/AdvancedSelection.aspx">Select All Rows</a> demo for more information.<br /><br />This sample illustrates how to add the "select all" check box dynamically within the HeaderCaptionTemplateContainer of the command column using the ITemplate interface.</p>

<br/>


