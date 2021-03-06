﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by SpecFlow (http://www.specflow.org/).
'     SpecFlow Version:1.9.0.77
'     SpecFlow Generator Version:1.9.0.0
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
#Region "Designer generated code"
'#pragma warning disable
Imports TechTalk.SpecFlow

Namespace SpecFlow.GeneratedTests
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()>  _
    Partial Public Class AddCustomerFeature
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
#ExternalSource("SpecFlowFeature1.feature",1)
#End ExternalSource
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()>  _
        Public Shared Sub FeatureSetup(ByVal testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("en-US"), "Add Customer", "Allow users to create and store new customers"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"As long as the new customers have "& _ 
                    "a first and last name", ProgrammingLanguage.VB, CType(Nothing,String()))
            testRunner.OnFeatureStart(featureInfo)
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()>  _
        Public Shared Sub FeatureTearDown()
            testRunner.OnFeatureEnd
            testRunner = Nothing
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()>  _
        Public Overridable Sub TestInitialize()
            If ((Not (TechTalk.SpecFlow.FeatureContext.Current) Is Nothing)  _
                        AndAlso (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title <> "Add Customer")) Then
                SpecFlow.GeneratedTests.AddCustomerFeature.FeatureSetup(Nothing)
            End If
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()>  _
        Public Overridable Sub ScenarioTearDown()
            testRunner.OnScenarioEnd
        End Sub
        
        Public Overridable Sub ScenarioSetup(ByVal scenarioInfo As TechTalk.SpecFlow.ScenarioInfo)
            testRunner.OnScenarioStart(scenarioInfo)
        End Sub
        
        Public Overridable Sub ScenarioCleanup()
            testRunner.CollectScenarioErrors
        End Sub
        ' Scenario 1: Happy Path

        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Happy Path"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Customer"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddCustomerHappyPathSteps")>  _
        Public Overridable Sub HappyPath()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Happy Path", New String() {"AddCustomerHappyPathSteps"})
#ExternalSource("SpecFlowFeature1.feature",6)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",7)
testRunner.Given("a user has entered information about a customer", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",8)
testRunner.And("she has provided a first name and a last name as required", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",9)
testRunner.When("she completes entering more information", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",10)
testRunner.Then("that customer should be stored in the system", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        ' Scenario 2: Missing Information   

        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Missing First or Last Name"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Customer"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AddCustomerMissingFirstorLastNameSteps")>  _
        Public Overridable Sub MissingFirstOrLastName()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Missing First or Last Name", New String() {"AddCustomerMissingFirstorLastNameSteps"})
#ExternalSource("SpecFlowFeature1.feature",14)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",15)
            'This piece is overlapped
testRunner.Given("a user has entered information about a customer", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",16)
testRunner.And("she has not provided both the firstname and lastname", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",17)
            'This piece is overlapped
testRunner.When("she completes entering more information", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",18)
testRunner.Then("that user will get a message", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
#ExternalSource("SpecFlowFeature1.feature",19)
testRunner.And("the customer will not be stored into the system", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
    End Class
End Namespace
'#pragma warning restore
#End Region
