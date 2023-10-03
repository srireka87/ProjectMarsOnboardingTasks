Feature: LanguageFeature

As a ProjectMars User
I want to Add,Update and Delete profile Langauage details
So that I can show people seeking what languags I hold 

@AddingNewLanguages
Scenario Outline:AddNew Language with Valid Credentials
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	When I '<AddLanguage>' and '<Language Level>'
    Then the'<AddLanguage>'and '<Language Level>' details should be created successfully
	
	Examples:
	| AddLanguage                                                          | Language Level   |
	| French                                                               | Basic            |
	| PERSIAN AND URUDHU                                                   | Basic            |
	| Japanese & English                                                   | Native/Bilingual |
	| Hi I am doing Test Analyst Program and implementing SPECFLOW and BDD | Conversational   |
	

@UpdateLanguages
Scenario Outline:Updating Language with Valid credentials in Profile
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	And Adding '<NewLanguage>' and '<NewLanguage Level>'
	When I Update '<UpdateLanguage>' and '<UpdateLanguage Level>' 
	Then the record should be updated in '<UpdateLanguage>'and '<UpdateLanguage Level>' successfully
	Examples:
	| UpdateLanguage                              | UpdateLanguage Level | NewLanguage          | NewLanguage Level |
	| English                                     | Fluent               | Persian              | Basic             |
	| @#423SFssfUpdating                          | Conversational       | Sindhi & Marathi     | Fluent            |
	| How many??languages##arethereinthe* (world) | Native/Bilingual     | **There are many@@## | Converational     |


@Adding/UpdatingExistingLanguages
Scenario Outline: Adding & Updating  the ExistingLanguage
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	And Adding '<SameLanguage>' and '<SameLanguage Level>'
	When I Updating '<SameLanguage>' and '<SameLanguage Level>' on existing records
	Then pop up message display as 'This language is already added to your language list.'
	Examples:
	| SameLanguage          | SameLanguage Level |
	| French                | Basic              |
	| Mandarin234           | Fluent             |
	| update23432Great#%#22 | Conversational     |  


@DeletingLanguages
Scenario Outline: Deleting the Language and Language Level
Given I logged in to ProjectMars successfully
And I navigate to Profile Language Page
And Adding '<Language>' and '<Language Level>'
When I click Delete Button for the '<Language>' 
Then the records should be deleted and message display as '<Language> has been deleted from your languages'
Examples: 
| Language  | Language Level     |
| Mandarin  | Basic              |
| Gujarathi | Fluent             |
| Greek     | Native/Bilingual   |


@CancelLanguage
Scenario Outline:Cancel the Language when AddNew and Update
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	When I adding'<Language>' and '<Language Level>'
	And Click Cancel Button
	Then the'<Language>'and '<Language Level>' details should be cancelled successfully
	Examples:
	| Language     | Language Level  |
	| English      | Fluent          |    
	| Arabic       | Basic	         |


@EnteringOnlyLanguageORLevel
Scenario Outline:AddNew Language with INVALID Credentials
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Language Page
	When I  enter only '<Language>' OR '<Language Level>'
	Then notification display as 'Please enter language and level'
	
	Examples:
	| Language | Language Level |
	| Arabic   |                |
	|          | Fluent         |
	| Bengali  |                |  


@ResettingTheState_DeletingAllRecords
 Scenario Outline:Deleting all the records
 Given I logged in to ProjectMars successfully
 And I navigate to Profile Language Page
 When Delete all records if exists
 Then I verify that all records been deleted.
 
	

 


