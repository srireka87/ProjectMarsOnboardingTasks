﻿Feature: LanguageFeature

As a ProjectMars User
I want to Add ,Update and Delete profile Langauage details
So that I can show people seeking what languags I hold 

@tag1
Scenario:AddNew Language with Valid details
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	When I Add a NewLanguage and Language Level
	Then the Language details should be created successfully


