using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Selenium_CSharp
{
    public class mPaige
    {
        Status status = new Status(false);
        //private Dictionary<string, string> data;
        private IWebDriver driver;
        //private int timeout = 15;

        #region Locators

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement ajaxFormSubmit1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement ajaxFormSubmit2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(2)")]
        [CacheLookup]
        private IWebElement ajaxFormSubmit3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement alertsModals1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement alertsModals2;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch a")]
        [CacheLookup]
        private IWebElement allExamples;

        [FindsBy(How = How.CssSelector, Using = "a[href='../ant-tutorials']")]
        [CacheLookup]
        private IWebElement antTutorial;

        [FindsBy(How = How.CssSelector, Using = "a[href='../apachepoi-tutorials']")]
        [CacheLookup]
        private IWebElement apachePoi;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapAlerts1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapAlerts2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(7)")]
        [CacheLookup]
        private IWebElement bootstrapAlerts3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapDatePicker1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(2) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapDatePicker2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(7)")]
        [CacheLookup]
        private IWebElement bootstrapDownloadProgressBar;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapListBox1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapListBox2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(4)")]
        [CacheLookup]
        private IWebElement bootstrapListBox3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement bootstrapModals1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement bootstrapModals2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(8)")]
        [CacheLookup]
        private IWebElement bootstrapModals3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement bootstrapProgressBar1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement bootstrapProgressBar2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement chartsDemo1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement chartsDemo2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(11)")]
        [CacheLookup]
        private IWebElement chartsDemo3;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(2)")]
        [CacheLookup]
        private IWebElement checkBoxDemo;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement checkboxDemo1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement checkboxDemo2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement dataListFilter1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement dataListFilter2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(6)")]
        [CacheLookup]
        private IWebElement dataListFilter3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(2) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement datePickers1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement datePickers2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/test']")]
        [CacheLookup]
        private IWebElement demoHome;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement dragAndDrop1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement dragAndDrop2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(9)")]
        [CacheLookup]
        private IWebElement dragAndDrop3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement dragDropSliders1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement dragDropSliders2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(8)")]
        [CacheLookup]
        private IWebElement dragDropSliders3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement dynamicDataLoading1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement dynamicDataLoading2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(10)")]
        [CacheLookup]
        private IWebElement dynamicDataLoading3;

        [FindsBy(How = How.CssSelector, Using = "a[href='../maven-tutorials/how-to-execute-selenium-webdriver-testng-xml-using-maven']")]
        [CacheLookup]
        private IWebElement executeSeleniumTestsUsingMaven;

        [FindsBy(How = How.CssSelector, Using = "a[href='../jenkins-tutorials/invoke-testng-xml-tests-from-jenkins']")]
        [CacheLookup]
        private IWebElement executeTestsInJenkins;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement fileDownload1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement fileDownload2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(8)")]
        [CacheLookup]
        private IWebElement fileDownload3;

        [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials/launching-firefox-browser-with-geckodriver-selenium-3']")]
        [CacheLookup]
        private IWebElement geckoDriverSelenium3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement inputFormSubmit1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement inputFormSubmit2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(1)")]
        [CacheLookup]
        private IWebElement inputFormWithValidations;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement inputForms1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement inputForms2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement javascriptAlerts1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement javascriptAlerts2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(5)")]
        [CacheLookup]
        private IWebElement javascriptAlerts3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement jqueryDatePicker1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(2) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement jqueryDatePicker2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement jqueryDownloadProgressBars1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement jqueryDownloadProgressBars2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(6)")]
        [CacheLookup]
        private IWebElement jqueryDownloadProgressBars3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement jqueryListBox1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement jqueryListBox2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(5)")]
        [CacheLookup]
        private IWebElement jqueryListBox3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement jquerySelectDropdown1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement jquerySelectDropdown2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(3)")]
        [CacheLookup]
        private IWebElement jquerySelectDropdown3;

        [FindsBy(How = How.CssSelector, Using = "a[href='../junit-tutorials']")]
        [CacheLookup]
        private IWebElement junitTutorial;

        [FindsBy(How = How.CssSelector, Using = "a[href='../jxl-tutorials']")]
        [CacheLookup]
        private IWebElement jxlTutorial;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement listBox1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement listBox2;

        [FindsBy(How = How.CssSelector, Using = "a[href='../maven-tutorials']")]
        [CacheLookup]
        private IWebElement mavenTutorial;

        [FindsBy(How = How.CssSelector, Using = "a.right.carousel-control")]
        [CacheLookup]
        private IWebElement next;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement others1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement others2;

        [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials/page-factory-pattern-in-selenium-webdriver']")]
        [CacheLookup]
        private IWebElement pageFactoryPattern;

        private readonly string pageLoadedText = "Execute Selenium tests using Maven";

        public readonly string pageUrl = "https://www.seleniumeasy.com/test/";

        [FindsBy(How = How.CssSelector, Using = "a.left.carousel-control")]
        [CacheLookup]
        private IWebElement previous;

        [FindsBy(How = How.Id, Using = "btn_inter_example")]
        [CacheLookup]
        private IWebElement proceedNext1;

        [FindsBy(How = How.Id, Using = "btn_advanced_example")]
        [CacheLookup]
        private IWebElement proceedNext2;

        [FindsBy(How = How.Id, Using = "btn_done_example")]
        [CacheLookup]
        private IWebElement proceedNext3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement progressBarModal1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement progressBarModal2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(7)")]
        [CacheLookup]
        private IWebElement progressBarModal3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement progressBars;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement progressBarsSliders;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement radioButtonsDemo1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement radioButtonsDemo2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(3)")]
        [CacheLookup]
        private IWebElement radioButtonsDemo3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement selectDropdownList1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement selectDropdownList2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(4)")]
        [CacheLookup]
        private IWebElement selectDropdownList3;

        [FindsBy(How = How.CssSelector, Using = "#site-name a")]
        [CacheLookup]
        private IWebElement seleniumEasy;

        [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials']")]
        [CacheLookup]
        private IWebElement seleniumTutorials;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement simpleFormDemo1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement simpleFormDemo2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(1)")]
        [CacheLookup]
        private IWebElement simpleFormDemo3;

        [FindsBy(How = How.Id, Using = "btn_basic_example")]
        [CacheLookup]
        private IWebElement startPractising;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement table1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement table2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement tableDataDownload1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement tableDataDownload2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(5)")]
        [CacheLookup]
        private IWebElement tableDataDownload3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement tableDataSearch1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement tableDataSearch2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(2)")]
        [CacheLookup]
        private IWebElement tableDataSearch3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement tableFilter1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement tableFilter2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(3)")]
        [CacheLookup]
        private IWebElement tableFilter3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement tablePagination1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement tablePagination2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(1)")]
        [CacheLookup]
        private IWebElement tablePagination3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement tableSortSearch1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement tableSortSearch2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(4)")]
        [CacheLookup]
        private IWebElement tableSortSearch3;

        [FindsBy(How = How.CssSelector, Using = "a[href='../testng-tutorials/testng-customize-emailable-html-report-example']")]
        [CacheLookup]
        private IWebElement testngCustomReport;

        [FindsBy(How = How.CssSelector, Using = "a[href='../testng-tutorials']")]
        [CacheLookup]
        private IWebElement testngTutorial;

        [FindsBy(How = How.CssSelector, Using = "button.navbar-toggle")]
        [CacheLookup]
        private IWebElement toggleNavigation;

        [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-webdriver-tutorials']")]
        [CacheLookup]
        private IWebElement viewAllSeleniumTutorials;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement windowPopupModal1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement windowPopupModal2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(6)")]
        [CacheLookup]
        private IWebElement windowPopupModal3;

        #endregion

        #region Constructors

        public mPaige()
            : this(default(IWebDriver))
        {
            PageFactory.InitElements(propertiesCollection.driver, this);
        }

        public mPaige(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(propertiesCollection.driver, this);
        }

        #endregion

        #region operations

        /// <summary>
        /// Click on Ajax Form Submit Link.
        /// </summary>
        /// <returns>The mPaige class instance.</returns>
        public Status ClickAjaxFormSubmit1Link()
        {
            try
            {
                ajaxFormSubmit1.Click();
                return status;
            }
            catch (Exception e)
            {
                status.ErrorOccurred = true;
                status.ReturnedMessage += e.StackTrace;
                status.ReturnedValue = 1;
                return status;
                //throw;
            }

        }

        /// <summary>
        /// Click on Ajax Form Submit Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickAjaxFormSubmit2Link()
        {
            ajaxFormSubmit2.Click();
            return status;
        }

        /// <summary>
        /// Click on Ajax Form Submit Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickAjaxFormSubmit3Link()
        {
            ajaxFormSubmit3.Click();
            return status;
        }

        /// <summary>
        /// Click on Alerts Modals Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickAlertsModals1Link()
        {
            alertsModals1.Click();
            return status;
        }

        /// <summary>
        /// Click on Alerts Modals Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickAlertsModals2Link()
        {
            alertsModals2.Click();
            return status;
        }

        /// <summary>
        /// Click on All Examples Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickAllExamplesLink()
        {
            allExamples.Click();
            return status;
        }

        /// <summary>
        /// Click on Ant Tutorial Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickAntTutorialLink()
        {
            antTutorial.Click();
            return status;
        }

        /// <summary>
        /// Click on Apache Poi Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickApachePoiLink()
        {
            apachePoi.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Alerts Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapAlerts1Link()
        {
            bootstrapAlerts1.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Alerts Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapAlerts2Link()
        {
            bootstrapAlerts2.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Alerts Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapAlerts3Link()
        {
            bootstrapAlerts3.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Date Picker Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapDatePicker1Link()
        {
            bootstrapDatePicker1.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Date Picker Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapDatePicker2Link()
        {
            bootstrapDatePicker2.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Download Progress Bar Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapDownloadProgressBarLink()
        {
            bootstrapDownloadProgressBar.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap List Box Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapListBox1Link()
        {
            bootstrapListBox1.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap List Box Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapListBox2Link()
        {
            bootstrapListBox2.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap List Box Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapListBox3Link()
        {
            bootstrapListBox3.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Modals Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapModals1Link()
        {
            bootstrapModals1.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Modals Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapModals2Link()
        {
            bootstrapModals2.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Modals Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapModals3Link()
        {
            bootstrapModals3.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Progress Bar Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapProgressBar1Link()
        {
            bootstrapProgressBar1.Click();
            return status;
        }

        /// <summary>
        /// Click on Bootstrap Progress Bar Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickBootstrapProgressBar2Link()
        {
            bootstrapProgressBar2.Click();
            return status;
        }

        /// <summary>
        /// Click on Charts Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickChartsDemo1Link()
        {
            chartsDemo1.Click();
            return status;
        }

        /// <summary>
        /// Click on Charts Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickChartsDemo2Link()
        {
            chartsDemo2.Click();
            return status;
        }

        /// <summary>
        /// Click on Charts Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickChartsDemo3Link()
        {
            chartsDemo3.Click();
            return status;
        }

        /// <summary>
        /// Click on Check Box Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickCheckBoxDemoLink()
        {
            checkBoxDemo.Click();
            return status;
        }

        /// <summary>
        /// Click on Checkbox Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickCheckboxDemo1Link()
        {
            checkboxDemo1.Click();
            return status;
        }

        /// <summary>
        /// Click on Checkbox Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickCheckboxDemo2Link()
        {
            checkboxDemo2.Click();
            return status;
        }

        /// <summary>
        /// Click on Data List Filter Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDataListFilter1Link()
        {
            dataListFilter1.Click();
            return status;
        }

        /// <summary>
        /// Click on Data List Filter Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDataListFilter2Link()
        {
            dataListFilter2.Click();
            return status;
        }

        /// <summary>
        /// Click on Data List Filter Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDataListFilter3Link()
        {
            dataListFilter3.Click();
            return status;
        }

        /// <summary>
        /// Click on Date Pickers Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDatePickers1Link()
        {
            datePickers1.Click();
            return status;
        }

        /// <summary>
        /// Click on Date Pickers Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDatePickers2Link()
        {
            datePickers2.Click();
            return status;
        }

        /// <summary>
        /// Click on Demo Home Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDemoHomeLink()
        {
            demoHome.Click();
            return status;
        }

        /// <summary>
        /// Click on Drag And Drop Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDragAndDrop1Link()
        {
            dragAndDrop1.Click();
            return status;
        }

        /// <summary>
        /// Click on Drag And Drop Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDragAndDrop2Link()
        {
            dragAndDrop2.Click();
            return status;
        }

        /// <summary>
        /// Click on Drag And Drop Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDragAndDrop3Link()
        {
            dragAndDrop3.Click();
            return status;
        }

        /// <summary>
        /// Click on Drag Drop Sliders Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDragDropSliders1Link()
        {
            dragDropSliders1.Click();
            return status;
        }

        /// <summary>
        /// Click on Drag Drop Sliders Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDragDropSliders2Link()
        {
            dragDropSliders2.Click();
            return status;
        }

        /// <summary>
        /// Click on Drag Drop Sliders Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDragDropSliders3Link()
        {
            dragDropSliders3.Click();
            return status;
        }

        /// <summary>
        /// Click on Dynamic Data Loading Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDynamicDataLoading1Link()
        {
            dynamicDataLoading1.Click();
            return status;
        }

        /// <summary>
        /// Click on Dynamic Data Loading Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDynamicDataLoading2Link()
        {
            dynamicDataLoading2.Click();
            return status;
        }

        /// <summary>
        /// Click on Dynamic Data Loading Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickDynamicDataLoading3Link()
        {
            dynamicDataLoading3.Click();
            return status;
        }

        /// <summary>
        /// Click on Execute Selenium Tests Using Maven Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickExecuteSeleniumTestsUsingMavenLink()
        {
            executeSeleniumTestsUsingMaven.Click();
            return status;
        }

        /// <summary>
        /// Click on Execute Tests In Jenkins Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickExecuteTestsInJenkinsLink()
        {
            executeTestsInJenkins.Click();
            return status;
        }

        /// <summary>
        /// Click on File Download Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickFileDownload1Link()
        {
            fileDownload1.Click();
            return status;
        }

        /// <summary>
        /// Click on File Download Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickFileDownload2Link()
        {
            fileDownload2.Click();
            return status;
        }

        /// <summary>
        /// Click on File Download Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickFileDownload3Link()
        {
            fileDownload3.Click();
            return status;
        }

        /// <summary>
        /// Click on Gecko Driver Selenium 3 Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickGeckoDriverSelenium3Link()
        {
            geckoDriverSelenium3.Click();
            return status;
        }

        /// <summary>
        /// Click on Input Form Submit Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickInputFormSubmit1Link()
        {
            inputFormSubmit1.Click();
            return status;
        }

        /// <summary>
        /// Click on Input Form Submit Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickInputFormSubmit2Link()
        {
            inputFormSubmit2.Click();
            return status;
        }

        /// <summary>
        /// Click on Input Form With Validations Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickInputFormWithValidationsLink()
        {
            inputFormWithValidations.Click();
            return status;
        }

        /// <summary>
        /// Click on Input Forms Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickInputForms1Link()
        {
            inputForms1.Click();
            return status;
        }

        /// <summary>
        /// Click on Input Forms Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickInputForms2Link()
        {
            inputForms2.Click();
            return status;
        }

        /// <summary>
        /// Click on Javascript Alerts Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJavascriptAlerts1Link()
        {
            javascriptAlerts1.Click();
            return status;
        }

        /// <summary>
        /// Click on Javascript Alerts Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJavascriptAlerts2Link()
        {
            javascriptAlerts2.Click();
            return status;
        }

        /// <summary>
        /// Click on Javascript Alerts Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJavascriptAlerts3Link()
        {
            javascriptAlerts3.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery Date Picker Link.
        /// </summary>
        /// <returns>The mPaige class instance.</returns>
        public Status ClickJqueryDatePicker1Link()
        {
            jqueryDatePicker1.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery Date Picker Link.
        /// </summary>
        /// <returns>The mPaige class instance.</returns>
        public Status ClickJqueryDatePicker2Link()
        {
            jqueryDatePicker2.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery Download Progress Bars Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJqueryDownloadProgressBars1Link()
        {
            jqueryDownloadProgressBars1.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery Download Progress Bars Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJqueryDownloadProgressBars2Link()
        {
            jqueryDownloadProgressBars2.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery Download Progress Bars Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJqueryDownloadProgressBars3Link()
        {
            jqueryDownloadProgressBars3.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery List Box Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJqueryListBox1Link()
        {
            jqueryListBox1.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery List Box Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJqueryListBox2Link()
        {
            jqueryListBox2.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery List Box Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJqueryListBox3Link()
        {
            jqueryListBox3.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery Select Dropdown Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJquerySelectDropdown1Link()
        {
            jquerySelectDropdown1.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery Select Dropdown Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJquerySelectDropdown2Link()
        {
            jquerySelectDropdown2.Click();
            return status;
        }

        /// <summary>
        /// Click on Jquery Select Dropdown Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJquerySelectDropdown3Link()
        {
            jquerySelectDropdown3.Click();
            return status;
        }

        /// <summary>
        /// Click on Junit Tutorial Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJunitTutorialLink()
        {
            junitTutorial.Click();
            return status;
        }

        /// <summary>
        /// Click on Jxl Tutorial Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickJxlTutorialLink()
        {
            jxlTutorial.Click();
            return status;
        }

        /// <summary>
        /// Click on List Box Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickListBox1Link()
        {
            listBox1.Click();
            return status;
        }

        /// <summary>
        /// Click on List Box Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickListBox2Link()
        {
            listBox2.Click();
            return status;
        }

        /// <summary>
        /// Click on Maven Tutorial Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickMavenTutorialLink()
        {
            mavenTutorial.Click();
            return status;
        }

        /// <summary>
        /// Click on Next Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickNextLink()
        {
            next.Click();
            return status;
        }

        /// <summary>
        /// Click on Others Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickOthers1Link()
        {
            others1.Click();
            return status;
        }

        /// <summary>
        /// Click on Others Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickOthers2Link()
        {
            others2.Click();
            return status;
        }

        /// <summary>
        /// Click on Page Factory Pattern Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickPageFactoryPatternLink()
        {
            pageFactoryPattern.Click();
            return status;
        }

        /// <summary>
        /// Click on Previous Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickPreviousLink()
        {
            previous.Click();
            return status;
        }

        /// <summary>
        /// Click on Proceed Next Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickProceedNext1Link()
        {
            proceedNext1.Click();
            return status;
        }

        /// <summary>
        /// Click on Proceed Next Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickProceedNext2Link()
        {
            proceedNext2.Click();
            return status;
        }

        /// <summary>
        /// Click on Proceed Next Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickProceedNext3Link()
        {
            proceedNext3.Click();
            return status;
        }

        /// <summary>
        /// Click on Progress Bar Modal Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickProgressBarModal1Link()
        {
            progressBarModal1.Click();
            return status;
        }

        /// <summary>
        /// Click on Progress Bar Modal Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickProgressBarModal2Link()
        {
            progressBarModal2.Click();
            return status;
        }

        /// <summary>
        /// Click on Progress Bar Modal Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickProgressBarModal3Link()
        {
            progressBarModal3.Click();
            return status;
        }

        /// <summary>
        /// Click on Progress Bars Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickProgressBarsLink()
        {
            progressBars.Click();
            return status;
        }

        /// <summary>
        /// Click on Progress Bars Sliders Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickProgressBarsSlidersLink()
        {
            progressBarsSliders.Click();
            return status;
        }

        /// <summary>
        /// Click on Radio Buttons Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickRadioButtonsDemo1Link()
        {
            radioButtonsDemo1.Click();
            return status;
        }

        /// <summary>
        /// Click on Radio Buttons Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickRadioButtonsDemo2Link()
        {
            radioButtonsDemo2.Click();
            return status;
        }

        /// <summary>
        /// Click on Radio Buttons Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickRadioButtonsDemo3Link()
        {
            radioButtonsDemo3.Click();
            return status;
        }

        /// <summary>
        /// Click on Select Dropdown List Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickSelectDropdownList1Link()
        {
            selectDropdownList1.Click();
            return status;
        }

        /// <summary>
        /// Click on Select Dropdown List Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickSelectDropdownList2Link()
        {
            selectDropdownList2.Click();
            return status;
        }

        /// <summary>
        /// Click on Select Dropdown List Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickSelectDropdownList3Link()
        {
            selectDropdownList3.Click();
            return status;
        }

        /// <summary>
        /// Click on Selenium Easy Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickSeleniumEasyLink()
        {
            seleniumEasy.Click();
            return status;
        }

        /// <summary>
        /// Click on Selenium Tutorials Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickSeleniumTutorialsLink()
        {
            seleniumTutorials.Click();
            return status;
        }

        /// <summary>
        /// Click on Simple Form Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickSimpleFormDemo1Link()
        {
            simpleFormDemo1.Click();
            return status;
        }

        /// <summary>
        /// Click on Simple Form Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickSimpleFormDemo2Link()
        {
            simpleFormDemo2.Click();
            return status;
        }

        /// <summary>
        /// Click on Simple Form Demo Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickSimpleFormDemo3Link()
        {
            simpleFormDemo3.Click();
            return status;
        }

        /// <summary>
        /// Click on Start Practising Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickStartPractisingLink()
        {
            startPractising.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTable1Link()
        {
            table1.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTable2Link()
        {
            table2.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Data Download Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableDataDownload1Link()
        {
            tableDataDownload1.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Data Download Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableDataDownload2Link()
        {
            tableDataDownload2.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Data Download Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableDataDownload3Link()
        {
            tableDataDownload3.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Data Search Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableDataSearch1Link()
        {
            tableDataSearch1.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Data Search Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableDataSearch2Link()
        {
            tableDataSearch2.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Data Search Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableDataSearch3Link()
        {
            tableDataSearch3.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Filter Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableFilter1Link()
        {
            tableFilter1.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Filter Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableFilter2Link()
        {
            tableFilter2.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Filter Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableFilter3Link()
        {
            tableFilter3.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Pagination Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTablePagination1Link()
        {
            tablePagination1.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Pagination Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTablePagination2Link()
        {
            tablePagination2.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Pagination Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTablePagination3Link()
        {
            tablePagination3.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Sort Search Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableSortSearch1Link()
        {
            tableSortSearch1.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Sort Search Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableSortSearch2Link()
        {
            tableSortSearch2.Click();
            return status;
        }

        /// <summary>
        /// Click on Table Sort Search Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTableSortSearch3Link()
        {
            tableSortSearch3.Click();
            return status;
        }

        /// <summary>
        /// Click on Testng Custom Report Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTestngCustomReportLink()
        {
            testngCustomReport.Click();
            return status;
        }

        /// <summary>
        /// Click on Testng Tutorial Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickTestngTutorialLink()
        {
            testngTutorial.Click();
            return status;
        }

        /// <summary>
        /// Click on Toggle Navigation Button.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickToggleNavigationButton()
        {
            toggleNavigation.Click();
            return status;
        }

        /// <summary>
        /// Click on View All Selenium Tutorials Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickViewAllSeleniumTutorialsLink()
        {
            viewAllSeleniumTutorials.Click();
            return status;
        }

        /// <summary>
        /// Click on Window Popup Modal Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickWindowPopupModal1Link()
        {
            windowPopupModal1.Click();
            return status;
        }

        /// <summary>
        /// Click on Window Popup Modal Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickWindowPopupModal2Link()
        {
            windowPopupModal2.Click();
            return status;
        }

        /// <summary>
        /// Click on Window Popup Modal Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status ClickWindowPopupModal3Link()
        {
            windowPopupModal3.Click();
            return status;
        }

        /// <summary>
        /// Submit the form to target page.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public Status Submit()
        {
            //ClickInputFormWithValidationsLink
            return status;
        }

        /// <summary>
        /// Verify that the page loaded completely.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        //public Status VerifyPageLoaded()
        //{
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        //    {
        //        status.CustomMessage =   d.PageSource.   //d.PageSource.Contains(pageLoadedText);
        //    });
        //    return status;
        //}

        /// <summary>
        /// Verify that current page URL matches the expected URL.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        //public Status VerifyPageUrl()
        //{
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        //    {
        //        return d.Url.Contains(pageUrl);
        //    });
        //    return status;
        //}
        #endregion
    }

}
