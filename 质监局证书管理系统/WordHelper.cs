/***************************************************************************
 * word辅助类
 * 作者：chengfellow
 * 日期：2008.8.18
 * 注意事项：
 * 1、开发环境居于office 2003；
 * 2、需要添加Com引用：Microsoft Office 11.0 Object Library和
 *    Microsoft Word 11.0 Object Library。
 * 
 ****************************************************************************/


using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Word;

namespace 质监局证书管理系统
{
    public class WordHelp
    {
        private Word.ApplicationClass oWordApplic;    // a reference to Word application

        public Word.ApplicationClass OWordApplic
        {
            get { return oWordApplic; }
            set { oWordApplic = value; }
        }
        private Word.Document oDoc;                    // a reference to the document

        public Word.Document ODoc
        {
            get { return oDoc; }
            set { oDoc = value; }
        }
        object missing = System.Reflection.Missing.Value;

        public Word.ApplicationClass WordApplication
        {
            get { return OWordApplic; }
        }

        public WordHelp()
        {
            // activate the interface with the COM object of Microsoft Word
            oWordApplic = new Word.ApplicationClass();
        }

        public WordHelp(Word.ApplicationClass wordapp)
        {
            oWordApplic = wordapp;
        }
        #region 页眉页脚

        #region 文件操作

        // Open a file (the file must exists) and activate it
        public void Open(string strFileName)
        {
            object fileName = strFileName;
            object readOnly = false;
            object isVisible = true;

            ODoc = OWordApplic.Documents.Open(ref fileName, ref missing, ref readOnly,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);

            ODoc.Activate();
        }

        // Open a new document
        public void Open()
        {
            ODoc = OWordApplic.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            ODoc.Activate();
        }

        public void Quit()
        {
            OWordApplic.Application.Quit(ref missing, ref missing, ref missing);
        }

        /// <summary>
        /// 附加dot模版文件
        /// </summary>
        private void LoadDotFile(string strDotFile)
        {
            if (!string.IsNullOrEmpty(strDotFile))
            {
                Word.Document wDot = null;
                if (OWordApplic != null)
                {
                    ODoc = OWordApplic.ActiveDocument;

                    OWordApplic.Selection.WholeStory();

                    //string strContent = oWordApplic.Selection.Text;

                    OWordApplic.Selection.Copy();
                    wDot = CreateWordDocument(strDotFile, true);

                    object bkmC = "Content";

                    if (OWordApplic.ActiveDocument.Bookmarks.Exists("Content") == true)
                    {
                        OWordApplic.ActiveDocument.Bookmarks.get_Item
                        (ref bkmC).Select();
                    }

                    //对标签"Content"进行填充
                    //直接写入内容不能识别表格什么的
                    //oWordApplic.Selection.TypeText(strContent);
                    OWordApplic.Selection.Paste();
                    OWordApplic.Selection.WholeStory();
                    OWordApplic.Selection.Copy();
                    wDot.Close(ref missing, ref missing, ref missing);

                    ODoc.Activate();
                    OWordApplic.Selection.Paste();

                }
            }
        }

        ///  
        /// 打开Word文档,并且返回对象oDoc
        /// 完整Word文件路径+名称  
        /// 返回的Word.Document oDoc对象 
        public Word.Document CreateWordDocument(string FileName, bool HideWin)
        {
            if (FileName == "") return null;

            OWordApplic.Visible = HideWin;
            OWordApplic.Caption = "";
            OWordApplic.Options.CheckSpellingAsYouType = false;
            OWordApplic.Options.CheckGrammarAsYouType = false;

            Object filename = FileName;
            Object ConfirmConversions = false;
            Object ReadOnly = true;
            Object AddToRecentFiles = false;

            Object PasswordDocument = System.Type.Missing;
            Object PasswordTemplate = System.Type.Missing;
            Object Revert = System.Type.Missing;
            Object WritePasswordDocument = System.Type.Missing;
            Object WritePasswordTemplate = System.Type.Missing;
            Object Format = System.Type.Missing;
            Object Encoding = System.Type.Missing;
            Object Visible = System.Type.Missing;
            Object OpenAndRepair = System.Type.Missing;
            Object DocumentDirection = System.Type.Missing;
            Object NoEncodingDialog = System.Type.Missing;
            Object XMLTransform = System.Type.Missing;
            try
            {
                Word.Document wordDoc = OWordApplic.Documents.Open(ref filename, ref ConfirmConversions,
                ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate,
                ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format,
                ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection,
                ref NoEncodingDialog, ref XMLTransform);
                return wordDoc;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void SaveAs(Word.Document oDoc, string strFileName)
        {
            object fileName = strFileName;
            if (File.Exists(strFileName))
            {
                if (MessageBox.Show("文件'" + strFileName + "'已经存在，选确定覆盖原文件，选取消退出操作！", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    oDoc.SaveAs(ref fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                              ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                }
                else
                {
                    Clipboard.Clear();
                }
            }
            else
            {
                oDoc.SaveAs(ref fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            }
        }

        public void SaveAsHtml(Word.Document oDoc, string strFileName)
        {
            object fileName = strFileName;

            //wdFormatWebArchive保存为单个网页文件
            //wdFormatFilteredHTML保存为过滤掉word标签的htm文件，缺点是有图片的话会产生网页文件夹
            if (File.Exists(strFileName))
            {
                if (MessageBox.Show("文件'" + strFileName + "'已经存在，选确定覆盖原文件，选取消退出操作！", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    object Format = (int)Word.WdSaveFormat.wdFormatWebArchive;
                    oDoc.SaveAs(ref fileName, ref Format, ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                }
                else
                {
                    Clipboard.Clear();
                }
            }
            else
            {
                object Format = (int)Word.WdSaveFormat.wdFormatWebArchive;
                oDoc.SaveAs(ref fileName, ref Format, ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            }
        }

        public void Save()
        {
            ODoc.Save();
        }

        public void SaveAs(string strFileName)
        {
            object fileName = strFileName;

            ODoc.SaveAs(ref fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
        }

        // Save the document in HTML format
        public void SaveAsHtml(string strFileName)
        {
            object fileName = strFileName;
            object Format = (int)Word.WdSaveFormat.wdFormatHTML;
            ODoc.SaveAs(ref fileName, ref Format, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
        }
       

        #endregion

        #region 添加菜单(工具栏)项

        //添加单独的菜单项
        public void AddMenu(Microsoft.Office.Core.CommandBarPopup popuBar)
        {
            Microsoft.Office.Core.CommandBar menuBar = null;
            menuBar = this.OWordApplic.CommandBars["Menu Bar"];
            popuBar = (Microsoft.Office.Core.CommandBarPopup)this.OWordApplic.CommandBars.FindControl(Microsoft.Office.Core.MsoControlType.msoControlPopup, missing, popuBar.Tag, true);
            if (popuBar == null)
            {
                popuBar = (Microsoft.Office.Core.CommandBarPopup)menuBar.Controls.Add(Microsoft.Office.Core.MsoControlType.msoControlPopup, missing, missing, missing, missing);
            }
        }

        //添加单独工具栏
        public void AddToolItem(string strBarName, string strBtnName)
        {
            Microsoft.Office.Core.CommandBar toolBar = null;
            toolBar = (Microsoft.Office.Core.CommandBar)this.OWordApplic.CommandBars.FindControl(Microsoft.Office.Core.MsoControlType.msoControlButton, missing, strBarName, true);
            if (toolBar == null)
            {
                toolBar = (Microsoft.Office.Core.CommandBar)this.OWordApplic.CommandBars.Add(
                     Microsoft.Office.Core.MsoControlType.msoControlButton,
                     missing, missing, missing);
                toolBar.Name = strBtnName;
                toolBar.Visible = true;
            }
        }

        #endregion

        #region 移动光标位置
        //进入编辑页眉页脚
        public void GotoFoot()
        {
            OWordApplic.ActiveWindow.View.Type = Word.WdViewType.wdOutlineView;
            OWordApplic.ActiveWindow.View.SeekView = Word.WdSeekView.wdSeekCurrentPageFooter;

        }
        #endregion
        // Go to a predefined bookmark, if the bookmark doesn't exists the application will raise an error
        public void GotoBookMark(string strBookMarkName)
        {
            // VB :  Selection.GoTo What:=wdGoToBookmark, Name:="nome"
            object Bookmark = (int)Word.WdGoToItem.wdGoToBookmark;
            object NameBookMark = strBookMarkName;
            OWordApplic.Selection.GoTo(ref Bookmark, ref missing, ref missing, ref NameBookMark);
        }

        public void GoToTheEnd()
        {
            // VB :  Selection.EndKey Unit:=wdStory
            object unit;
            unit = Word.WdUnits.wdStory;
            OWordApplic.Selection.EndKey(ref unit, ref missing);
        }

        public void GoToLineEnd()
        {
            object unit = Word.WdUnits.wdLine;
            object ext = Word.WdMovementType.wdExtend;
            OWordApplic.Selection.EndKey(ref unit, ref ext);
        }

        public void GoToTheBeginning()
        {
            // VB : Selection.HomeKey Unit:=wdStory
            object unit;
            unit = Word.WdUnits.wdStory;
            OWordApplic.Selection.HomeKey(ref unit, ref missing);
        }

        public void GoToTheTable(int ntable)
        {
            //    Selection.GoTo What:=wdGoToTable, Which:=wdGoToFirst, Count:=1, Name:=""
            //    Selection.Find.ClearFormatting
            //    With Selection.Find
            //        .Text = ""
            //        .Replacement.Text = ""
            //        .Forward = True
            //        .Wrap = wdFindContinue
            //        .Format = False
            //        .MatchCase = False
            //        .MatchWholeWord = False
            //        .MatchWildcards = False
            //        .MatchSoundsLike = False
            //        .MatchAllWordForms = False
            //    End With

            object what;
            what = Word.WdUnits.wdTable;
            object which;
            which = Word.WdGoToDirection.wdGoToFirst;
            object count;
            count = 1;
            OWordApplic.Selection.GoTo(ref what, ref which, ref count, ref missing);
            OWordApplic.Selection.Find.ClearFormatting();

            OWordApplic.Selection.Text = "";
        }

        public void GoToRightCell()
        {
            // Selection.MoveRight Unit:=wdCell
            object direction;
            direction = Word.WdUnits.wdCell;
            OWordApplic.Selection.MoveRight(ref direction, ref missing, ref missing);
        }

        public void GoToLeftCell()
        {
            // Selection.MoveRight Unit:=wdCell
            object direction;
            direction = Word.WdUnits.wdCell;
            OWordApplic.Selection.MoveLeft(ref direction, ref missing, ref missing);
        }

        public void GoToDownCell()
        {
            // Selection.MoveRight Unit:=wdCell
            object direction;
            direction = Word.WdUnits.wdLine;
            OWordApplic.Selection.MoveDown(ref direction, ref missing, ref missing);
        }

        public void GoToUpCell()
        {
            // Selection.MoveRight Unit:=wdCell
            object direction;
            direction = Word.WdUnits.wdLine;
            OWordApplic.Selection.MoveUp(ref direction, ref missing, ref missing);
        }

        #endregion

        #region 插入操作

        public void InsertText(string strText)
        {
            OWordApplic.Selection.TypeText(strText);
        }

        public void InsertLineBreak()
        {
            OWordApplic.Selection.TypeParagraph();
        }

        /// <summary>
        /// 插入多个空行
        /// </summary>
        /// <param name="nline"></param>
        public void InsertLineBreak(int nline)
        {
            for (int i = 0; i < nline; i++)
                OWordApplic.Selection.TypeParagraph();
        }

        public void InsertPagebreak()
        {
            // VB : Selection.InsertBreak Type:=wdPageBreak
            object pBreak = (int)Word.WdBreakType.wdPageBreak;
            OWordApplic.Selection.InsertBreak(ref pBreak);
        }

        // 插入页码
        public void InsertPageNumber()
        {
            object wdFieldPage = Word.WdFieldType.wdFieldPage;
            object preserveFormatting = true;
            OWordApplic.Selection.Fields.Add(OWordApplic.Selection.Range, ref wdFieldPage, ref missing, ref preserveFormatting);
        }

        // 插入页码
        public void InsertPageNumber(string strAlign)
        {
            object wdFieldPage = Word.WdFieldType.wdFieldPage;
            object preserveFormatting = true;
            OWordApplic.Selection.Fields.Add(OWordApplic.Selection.Range, ref wdFieldPage, ref missing, ref preserveFormatting);
            SetAlignment(strAlign);
        }

        public void InsertImage(string strPicPath, float picWidth, float picHeight)
        {
            string FileName = strPicPath;
            object LinkToFile = false;
            object SaveWithDocument = true;
            object Anchor = OWordApplic.Selection.Range;
            OWordApplic.ActiveDocument.InlineShapes.AddPicture(FileName, ref LinkToFile, ref SaveWithDocument, ref Anchor).Select();
            OWordApplic.Selection.InlineShapes[1].Width = picWidth; // 图片宽度 
            OWordApplic.Selection.InlineShapes[1].Height = picHeight; // 图片高度

            // 将图片设置为四面环绕型 
            Word.Shape s = OWordApplic.Selection.InlineShapes[1].ConvertToShape();
            s.WrapFormat.Type = Word.WdWrapType.wdWrapSquare;
        }

        public void InsertLine(float left, float top, float width, float weight, int r, int g, int b)
        {
            //SetFontColor("red");
            //SetAlignment("Center");
            object Anchor = OWordApplic.Selection.Range;
            //int pLeft = 0, pTop = 0, pWidth = 0, pHeight = 0;
            //oWordApplic.ActiveWindow.GetPoint(out pLeft, out pTop, out pWidth, out pHeight,missing);
            //MessageBox.Show(pLeft + "," + pTop + "," + pWidth + "," + pHeight);
            object rep = false;
            //left += oWordApplic.ActiveDocument.PageSetup.LeftMargin;
            left = OWordApplic.CentimetersToPoints(left);
            top = OWordApplic.CentimetersToPoints(top);
            width = OWordApplic.CentimetersToPoints(width);
            Word.Shape s = OWordApplic.ActiveDocument.Shapes.AddLine(0, top, width, top, ref Anchor);
            s.Line.ForeColor.RGB = RGB(r, g, b);
            s.Line.Visible = Microsoft.Office.Core.MsoTriState.msoTrue;
            s.Line.Style = Microsoft.Office.Core.MsoLineStyle.msoLineSingle;
            s.Line.Weight = weight;
        }

        #endregion

        #region 设置样式

        /// <summary>
        /// Change the paragraph alignement
        /// </summary>
        /// <param name="strType"></param>
        public void SetAlignment(string strType)
        {
            switch (strType.ToLower())
            {
                case "center":
                    OWordApplic.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    break;
                case "left":
                    OWordApplic.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    break;
                case "right":
                    OWordApplic.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    break;
                case "justify":
                    OWordApplic.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    break;
            }

        }


        // if you use thif function to change the font you should call it again with 
        // no parameter in order to set the font without a particular format
        public void SetFont(string strType)
        {
            switch (strType)
            {
                case "Bold":
                    OWordApplic.Selection.Font.Bold = 1;
                    break;
                case "Italic":
                    OWordApplic.Selection.Font.Italic = 1;
                    break;
                case "Underlined":
                    OWordApplic.Selection.Font.Subscript = 0;
                    break;
            }
        }

        // disable all the style 
        public void SetFont()
        {
            OWordApplic.Selection.Font.Bold = 0;
            OWordApplic.Selection.Font.Italic = 0;
            OWordApplic.Selection.Font.Subscript = 0;

        }

        public void SetFontName(string strType)
        {
            OWordApplic.Selection.Font.Name = strType;
        }

        public void SetFontSize(float nSize)
        {
            SetFontSize(nSize, 100);
        }

        public void SetFontSize(float nSize, int scaling)
        {
            if (nSize > 0f)
                OWordApplic.Selection.Font.Size = nSize;
            if (scaling > 0)
                OWordApplic.Selection.Font.Scaling = scaling;
        }

        public void SetFontColor(string strFontColor)
        {
            switch (strFontColor.ToLower())
            {
                case "blue":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorBlue;
                    break;
                case "gold":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorGold;
                    break;
                case "gray":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorGray875;
                    break;
                case "green":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorGreen;
                    break;
                case "lightblue":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorLightBlue;
                    break;
                case "orange":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorOrange;
                    break;
                case "pink":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorPink;
                    break;
                case "red":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorRed;
                    break;
                case "yellow":
                    OWordApplic.Selection.Font.Color = Word.WdColor.wdColorYellow;
                    break;
            }
        }

        public void SetPageNumberAlign(string strType, bool bHeader)
        {
            object alignment;
            object bFirstPage = false;
            object bF = true;
            //if (bHeader == true)
            //WordApplic.Selection.HeaderFooter.PageNumbers.ShowFirstPageNumber = bF;
            switch (strType)
            {
                case "Center":
                    alignment = Word.WdPageNumberAlignment.wdAlignPageNumberCenter;
                    //WordApplic.Selection.HeaderFooter.PageNumbers.Add(ref alignment,ref bFirstPage);
                    //Word.Selection objSelection = WordApplic.pSelection;
                    OWordApplic.Selection.HeaderFooter.PageNumbers[1].Alignment = Word.WdPageNumberAlignment.wdAlignPageNumberCenter;
                    break;
                case "Right":
                    alignment = Word.WdPageNumberAlignment.wdAlignPageNumberRight;
                    OWordApplic.Selection.HeaderFooter.PageNumbers[1].Alignment = Word.WdPageNumberAlignment.wdAlignPageNumberRight;
                    break;
                case "Left":
                    alignment = Word.WdPageNumberAlignment.wdAlignPageNumberLeft;
                    OWordApplic.Selection.HeaderFooter.PageNumbers.Add(ref alignment, ref bFirstPage);
                    break;
            }
        }

        /// <summary>
        /// 设置页面为标准A4公文样式
        /// </summary>
        private void SetA4PageSetup()
        {
            OWordApplic.ActiveDocument.PageSetup.TopMargin = OWordApplic.CentimetersToPoints(3.7f);
            //oWordApplic.ActiveDocument.PageSetup.BottomMargin = oWordApplic.CentimetersToPoints(1f);
            OWordApplic.ActiveDocument.PageSetup.LeftMargin = OWordApplic.CentimetersToPoints(2.8f);
            OWordApplic.ActiveDocument.PageSetup.RightMargin = OWordApplic.CentimetersToPoints(2.6f);
            //oWordApplic.ActiveDocument.PageSetup.HeaderDistance = oWordApplic.CentimetersToPoints(2.5f);
            //oWordApplic.ActiveDocument.PageSetup.FooterDistance = oWordApplic.CentimetersToPoints(1f);
            OWordApplic.ActiveDocument.PageSetup.PageWidth = OWordApplic.CentimetersToPoints(21f);
            OWordApplic.ActiveDocument.PageSetup.PageHeight = OWordApplic.CentimetersToPoints(29.7f);
        }

        #endregion

        #region 替换

        ///<summary>
        /// 在word 中查找一个字符串直接替换所需要的文本
        /// </summary>
        /// <param name="strOldText">原文本</param>
        /// <param name="strNewText">新文本</param>
        /// <returns></returns>
        public bool Replace(string strOldText, string strNewText)
        {
            if (ODoc == null)
                ODoc = OWordApplic.ActiveDocument;
            this.ODoc.Content.Find.Text = strOldText;
            object FindText, ReplaceWith, Replace;// 
            FindText = strOldText;//要查找的文本
            ReplaceWith = strNewText;//替换文本
            Replace = Word.WdReplace.wdReplaceAll;/**//*wdReplaceAll - 替换找到的所有项。
                                                      * wdReplaceNone - 不替换找到的任何项。
                                                    * wdReplaceOne - 替换找到的第一项。
                                                    * */
            ODoc.Content.Find.ClearFormatting();//移除Find的搜索文本和段落格式设置
            if (ODoc.Content.Find.Execute(
                ref FindText, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref ReplaceWith, ref Replace,
                ref missing, ref missing,
                ref missing, ref missing))
            {
                return true;
            }
            return false;
        }

        public bool SearchReplace(string strOldText, string strNewText)
        {
            object replaceAll = Word.WdReplace.wdReplaceAll;

            //首先清除任何现有的格式设置选项，然后设置搜索字符串 strOldText。
            OWordApplic.Selection.Find.ClearFormatting();
            OWordApplic.Selection.Find.Text = strOldText;

            OWordApplic.Selection.Find.Replacement.ClearFormatting();
            OWordApplic.Selection.Find.Replacement.Text = strNewText;

            if (OWordApplic.Selection.Find.Execute(
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing))
            {
                return true;
            }
            return false;
        }

        #endregion
        /// <summary>
        /// rgb转换函数
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int RGB(int r, int g, int b)
        {
            return ((b << 16) | (ushort)(((ushort)g << 8) | r));
        }

        Color RGBToColor(int color)
        {
            int r = 0xFF & color;
            int g = 0xFF00 & color;
            g >>= 8;
            int b = 0xFF0000 & color;
            b >>= 16;
            return Color.FromArgb(r, g, b);
        }
    }
}