Feature: SkillsFeature

As a ProjectMars User 
I want to Add,Update and Delete profile Skills details
So that I can show people seeking what skills I hold 


@Skills_ADD
Scenario Outline:AddNew Skill with Valid Credentials
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Skills Page
	When I '<Add Skill>'and '<Skill Level>'
	Then The'<Add Skill>'and '<Skill Level>' details should be created successfully

	Examples:
	| Add Skill                                            | Skill Level  |
	| Cooking                                              | Expert       |
	| Documentation & Writing                              | Beginner     |
	| Graphics3287@$@                                      | Intermediate |
	| Painting is my ##passion$$ and trying 2 improve it@@ | Beginner     |

	
@Skills_UPDATE
Scenario Outline:Updating Skill with Valid credentials in Profile
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Skills Page
	And I Add '<NewSkill>' and '<NewSkill Level>'
	When Updating '<Update Skill>' and '<Update Level>' 
	Then skills should be updated in '<Update Skill>'and '<Update Level>' successfully
	Examples:
	| Update Skill       | Update Level | NewSkill                     | NewSkill Level |
	| Crafting           | Expert       | Music& Audio                 | Beginner       |
	| @#423SFssfUpdating | Beginner     | Fun Life Style and Organiser | Expert         |
	| Pottery & mosaic   | Intermediate | Sewing@@##FashionDesingning  | Intermediate   |



@Skills_SAMESKILL_EXISTS
Scenario Outline: Adding & Updating  the ExistingSkill
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Skills Page
	And I Add '<Skill>' and '<Skill Level>'
	When I Updating same '<Skill>' and '<Skill Level>'
	Then Popup message display as 'This skill is already added to your skill list.'
	Examples:
	| Skill                       | Skill Level   |  
	| Reading                     | Expert        |
	| Cooking                     | Intermediate |
	| @#@#@$^&^*#$#Gardening@#@#@ | Beginner      |

	
@Skills_DELETE
Scenario Outline: Deleting the Skill and Skill Level
Given I logged in to ProjectMars successfully
And I navigate to Profile Skills Page
And I Add '<Skill>' and '<Skill Level>'
When I Delete the '<Skill>' 
Then the record should be deleted and message display as '<Skill> has been deleted' 
Examples: 
| Skill               | Skill Level |
| Poetry              | Expert      |
| Writing documentary | Beginner    |


@Skill_CANCEL
Scenario Outline:Cancel the Skill when AddNew and Update
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Skills Page
	And I adding '<Skill>' and '<Skill Level>'
	Then Click Cancel Button
	Then the'<Skill>'and '<Skill Level>' details should be cancelled.
	Examples:
	| Skill        | Skill Level |
	| Gardening    | Beginner    |
	| Art & Design | Basic       |

@Skill_INVALID
Scenario Outline:AddNew Skill with INVALID Credentials
	Given I logged in to ProjectMars successfully
	And I navigate to Profile Skills Page
	When I enter only '<Skill>' OR '<Skill Level>'
	Then notification show as 'Please enter skill and experience level'
	
	Examples:
	| Skill      | Level        |
	| Hadwriting | Expert       |
	|            | Intermediate |
	| Animation  |              |
	