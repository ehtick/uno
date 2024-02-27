﻿using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Testing;
using Uno.UI.SourceGenerators.Tests.Verifiers;

namespace Uno.UI.SourceGenerators.Tests.XamlCodeGeneratorTests;

using Verify = XamlSourceGeneratorVerifier;

[TestClass]
public class Given_DeferLoadStrategy
{
	[TestMethod]
    	public async Task When_No_Visibility_Set()
    	{
    		var xamlFile = new XamlFile("MainPage.xaml", """
				<Page
					x:Class="TestRepro.MainPage"
					xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
					xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
					xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
					xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
					mc:Ignorable="d">

					<StackPanel>
						<TextBlock Text="Immediate content"/>
						<Border x:Name="LazyLoadedBorder" x:DeferLoadStrategy="Lazy">
							<TextBlock Text="Lazy Content" />
						</Border>
					</StackPanel>
				</Page>
				""");

    		var test = new Verify.Test(xamlFile)
    		{
    			TestState =
    			{
    				Sources =
    				{
    					"""
    					using System;
    					using Microsoft.UI.Xaml;
    					using Microsoft.UI.Xaml.Controls;
    
    					namespace TestRepro
    					{
    						public sealed partial class MainPage : Page
    						{
    							public MainPage()
    							{
    								this.InitializeComponent();
    							}
    						}
    					}
    					"""
    				}
    			},
    			ReferenceAssemblies = ReferenceAssemblies.Net.Net70.AddPackages(ImmutableArray.Create(new PackageIdentity("Uno.WinUI", "5.0.118"))),
    			DisableBuildReferences = true,
    		}.AddGeneratedSources();

    		await test.RunAsync();
    	}
}
