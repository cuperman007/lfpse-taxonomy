Taxonomy document for AdverseEvent v4

Desc: A profile for patient safety events used by the NHS Improvement Patient Safety Incident Management System

- Id: patient-safety-adverse-event-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-safety-adverse-event-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-safety-adverse-event-4)

## AdverseEventEstimatedDate

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-estimated-date-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-estimated-date-4) `Extension`

Desc: Information about the estimated date/time of the event

- Id: adverse-event-estimated-date-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-estimated-date-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-estimated-date-4)

### IncidentOccurredToday

 Definition: Indication of whether the event occurred today

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4)

The code system options for [Yes-No-Unknown Codes](/v4/code-systems/#yes-no-unknown-codes) are: 

 | Code | Display |
 | --- | --- |
| `  y` | Yes |
| `  n` | No |
| `  u` | I don't know |

### ApproximateDate

 Definition: An estimated date of the adverse event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### EstimatedTime

 Definition: Estimated time of the event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/time-of-incident-brackets-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/time-of-incident-brackets-4)

The code system options for [Time of Incident Brackets](/v4/code-systems/#time-of-incident-brackets) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Day shift |
| `  2` | Night shift |
| `  3` | Morning handover |
| `  4` | Evening handover |
| `  5` | None of the above |
| `  6` | I don't know |

### PreciseTime

 Definition: Known time of the adverse event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Time`

### TodaysDate

 Definition: The date today

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Date`

- Type: `[x]`

## AdverseEventProblem

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-4) `Extension`

Desc: Information about the problem that occurred

- Id: adverse-event-problem-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-4)

### DrugReaction

 Definition: Indication of whether an adverse event was due to an adverse drug reaction

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yellow-card-criteria-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yellow-card-criteria-4)

The code system options for [Criteria which would indicate whether an event is a yellow card incident](/v4/code-systems/#criteria-which-would-indicate-whether-an-event-is-a-yellow-card-incident) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Side effects (also known as Adverse Drug Reactions or ADRs) |
| `  2` | Defective or counterfeit medicines |
| `  3` | Defective or counterfeit medical devices |
| `  4` | Poor packaging or design of medicines that might lead to errors |
| `  5` | Poor packaging or design of medical devices that might lead to errors |
| `  6` | None of the above |
| `  7` | I don't know |
| `  8` | Other |

### DrugReactionOther

 Definition: Other indication of drug reaction

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ProblemDescriptionInvolvement

 Definition: A description of the problem in regards to people involved

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### PeopleInvolvementFactors

 Definition: How the involvement of people differed from expected

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-involvement-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-involvement-4)

The code system options for [People Involvement](/v4/code-systems/#people-involvement) are: 

 | Code | Display |
 | --- | --- |
| `  1` | There were too many people involved |
| `  2` | There were people absent who were required |
| `  3` | The wrong skill mix was involved |
| `  4` | Other |
| `  5` | I don't know |

### PeopleActionFactors

 Definition: How the actions of people differed from expected

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-actions-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-actions-4)

The code system options for [People Actions](/v4/code-systems/#people-actions) are: 

 | Code | Display |
 | --- | --- |
| `  1` | People did too much of something |
| `  2` | People did too little of something |
| `  3` | People did one thing when they meant to do another |
| `  4` | People did not do something they should have |
| `  5` | Other |
| `  6` | I don't know |

### DeviceInvolvementFactors

 Definition: How devices were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/devices-involved-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/devices-involved-4)

The code system options for [Devices involved](/v4/code-systems/#devices-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The device was used when it should not have been |
| `  2` | The device was not used when it should have been |
| `  3` | The device was used incorrectly |
| `  4` | The device was available but broken, not fit for use or didn't perform as expected |
| `  5` | The device was involved in an accident, trip or collision |
| `  6` | Other |
| `  7` | I don't know |

### DrugInvolvementFactors

 Definition: How drugs were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/drugs-involved-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/drugs-involved-4)

The code system options for [Drugs involved](/v4/code-systems/#drugs-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too much medication was prescribed/dispensed/administered |
| `  2` | Too little medication was prescribed/dispensed/administered |
| `  3` | The medication was prescribed/dispensed/administered incorrectly |
| `  4` | Something was wrong with the medication and/or it's packaging |
| `  5` | Other |
| `  6` | I don't know |

### FurnitureFittingsInvolvementFactors

 Definition: How furniture and fittings were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/furniture-fittings-involved-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/furniture-fittings-involved-4)

The code system options for [Furniture fittings involved](/v4/code-systems/#furniture-fittings-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Furniture or fittings were used or present when they should not have been |
| `  2` | Furniture or fittings were not used or present when they should have been |
| `  3` | The wrong furniture or fittings were used or present |
| `  4` | Furniture or fittings were broken or not fit for purpose |
| `  5` | Other |
| `  6` | I don't know |

### BuiltEnvironmentInvolvementFactors

 Definition: How the built environment was involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/built-environment-involved-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/built-environment-involved-4)

The code system options for [Built environment involved](/v4/code-systems/#built-environment-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Unnecessary elements of the built environment were used |
| `  2` | The required elements of the built environment were available but not used when they should have been |
| `  3` | The wrong elements of the built environment were used in place of the correct ones |
| `  4` | Required elements of the built environment were unavailable, unfit for use, or out of order |
| `  5` | Other |
| `  6` | I don't know |

### BloodProductsInvolvementFactors

 Definition: How blood and blood products were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-and-blood-products-involved-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-and-blood-products-involved-4)

The code system options for [Blood and blood products involved](/v4/code-systems/#blood-and-blood-products-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too great an amount of blood or blood products were used |
| `  2` | Too small an amount of blood or blood products were used |
| `  3` | The wrong blood or blood products were used in place of the correct ones |
| `  4` | Blood or blood products were not used when they should have been |
| `  5` | Blood or blood products were available but damaged or not fit for use |
| `  6` | Other |
| `  7` | I don't know |

### TissueOrgansInvolvementFactors

 Definition: How tissue and organs for transplant were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/tissue-and-organs-for-transplant-involved-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/tissue-and-organs-for-transplant-involved-4)

The code system options for [Tissue and organs for transplant involved](/v4/code-systems/#tissue-and-organs-for-transplant-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too much/many tissues or organs for transplant were used |
| `  2` | Too few/little tissues or organs for transplant were used |
| `  3` | The wrong tissues or organs for transplant were used |
| `  4` | Tissues or organs for transplant were not used when they should have been |
| `  5` | Tissues or organs for transplant were available but damaged or unfit for use |
| `  6` | Other |
| `  7` | I don't know |

### ITSystemsInvolvementFactors

 Definition: How IT systems and software were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/it-systems-and-software-involved-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/it-systems-and-software-involved-4)

The code system options for [IT systems and software involved](/v4/code-systems/#it-systems-and-software-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong IT system or software was used |
| `  2` | IT systems or software were used in a way they were not designed to be |
| `  3` | IT systems or software were not used when they should have been |
| `  4` | IT systems or software were faulty/malfunctioned |
| `  5` | IT systems or software was not fit for purpose/did not perform adequately |
| `  6` | Other |
| `  7` | I don't know |

### PeopleActionTooMuch

 Definition: How people took too much of an action

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-action-too-much-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-action-too-much-4)

The code system options for [People action too much](/v4/code-systems/#people-action-too-much) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Something was done too many times/too frequently |
| `  2` | Something was done too quickly |
| `  3` | Something was done for too long |
| `  4` | Something was done too early/soon |
| `  5` | Something was done with too much force |

### DeviceUsedUnnecessarily

 Definition: How a device was used unnecessarily

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-used-unnecessarily-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-used-unnecessarily-4)

The code system options for [Device used unnecessarily](/v4/code-systems/#device-used-unnecessarily) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too many devices were used/The device was not required |
| `  2` | The device was used too soon |
| `  3` | The device was used for too long |
| `  4` | The device was accidentally retained |
| `  5` | The device was overused or used on too high a setting |

### DrugUsedTooMuch

 Definition: How too much of a drug was used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-drug-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-drug-4)

The code system options for [Too much drug](/v4/code-systems/#too-much-drug) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The prescribed/dispensed/administered dosage was too high |
| `  2` | The medication was prescribed/dispensed/administered too early |
| `  3` | The medication was prescribed/dispensed/administered for too long a duration |
| `  4` | The medication was prescribed/dispensed/administered at too fast a rate |
| `  5` | The medication was prescribed/dispensed/administered too frequently |
| `  6` | The medication was prescribed/dispensed/administered when it should not have been |

### BloodProductsUsedTooMuch

 Definition: How too much blood or blood products were used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-blood-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-blood-4)

The code system options for [Too much blood](/v4/code-systems/#too-much-blood) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too great a quantity of a blood product was used |
| `  2` | Blood or blood products were used when they were not required |
| `  3` | Blood or blood products were used too soon |
| `  4` | Blood or blood products were used after they should have been withdrawn |
| `  5` | Blood or blood products were given too quickly |

### TissueOrgansUsedTooMuch

 Definition: How too much tissue and organs for transplant were used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-tissue-and-organs-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-tissue-and-organs-4)

The code system options for [Too much tissue and organs](/v4/code-systems/#too-much-tissue-and-organs) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too great a quantity or number of tissues or organs for transplant were used |
| `  2` | Tissues or organs for transplant were used when they were not required |
| `  3` | Tissues or organs for transplant were used too soon |

### PeopleUnavailableDetails

 Definition: How people were not available who should have been

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-unavailable-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-unavailable-4)

The code system options for [People unavailable](/v4/code-systems/#people-unavailable) are: 

 | Code | Display |
 | --- | --- |
| `  1` | People's arrival was delayed |
| `  2` | People were called away/had to leave too soon |
| `  3` | There was a shortage of available people |

### PeopleInsufficientActionDetails

 Definition: How people did not take enough of a necessary action

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-not-enough-action-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-not-enough-action-4)

The code system options for [People not enough action](/v4/code-systems/#people-not-enough-action) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Something was done too few times/not frequently enough |
| `  2` | Something was done too slowly |
| `  3` | Something was done too late |
| `  4` | Something was stopped too early |
| `  5` | Something was done with insufficient force |

### DeviceInsufficientDetails

 Definition: How the use of devices was insufficient

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/devices-insufficient-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/devices-insufficient-4)

The code system options for [Devices insufficient](/v4/code-systems/#devices-insufficient) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too few devices were used |
| `  2` | There was a delay in using the device |
| `  3` | The devices was not used for long enough |
| `  4` | The device was not available |
| `  5` | The device was underused or used on too low a setting |

### DrugInsufficientDetails

 Definition: How too little of a drug was used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-drug-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-drug-4)

The code system options for [Too little drug](/v4/code-systems/#too-little-drug) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The prescribed/dispensed/administered dosage was too low |
| `  2` | The medication was prescribed/dispensed/administered too late |
| `  3` | The medication was prescribed/dispensed/administered for too short a duration |
| `  4` | The medication was prescribed/dispensed/administered at too slow a rate |
| `  5` | The medication was not prescribed/dispensed/administered frequently enough |
| `  6` | The prescribed/dispensed/administered medication was omitted |

### BloodProductsInsufficientDetails

 Definition: How too little blood or blood products were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-blood-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-blood-4)

The code system options for [Too little blood](/v4/code-systems/#too-little-blood) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too little of a blood product was used |
| `  2` | There was a delay in using blood or blood products |
| `  3` | Blood or blood products were not given for long enough |
| `  4` | Blood or blood products were given too slowly |

### TissueOrgansInsufficientDetails

 Definition: How insufficient tissue or organs for transplant were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/way-insufficient-tissues-or-organs-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/way-insufficient-tissues-or-organs-4)

The code system options for [Way insufficient tissues or organs](/v4/code-systems/#way-insufficient-tissues-or-organs) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too little a quantity or number of tissues or organs for transplant were used |
| `  2` | There was a delay in using tissues or organs for transplant |

### PeopleIncorrectDetails

 Definition: How the incorrect people were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incorrect-people-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incorrect-people-4)

The code system options for [Incorrect people](/v4/code-systems/#incorrect-people) are: 

 | Code | Display |
 | --- | --- |
| `  1` | People were involved who did not have the right skills |
| `  2` | The wrong person was involved |
| `  3` | People who were not needed were involved |

### PeopleWrongActionDetails

 Definition: How people took the wrong actions

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-wrong-action-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-wrong-action-4)

The code system options for [People wrong action](/v4/code-systems/#people-wrong-action) are: 

 | Code | Display |
 | --- | --- |
| `  1` | One action was taken in place of another |
| `  2` | A wrong action was taken as well as the right one |
| `  3` | The right action was only partially completed |

### DeviceWrongUsageDetails

 Definition: How a device was used incorrectly

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-used-wrongly-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-used-wrongly-4)

The code system options for [Device used wrongly](/v4/code-systems/#device-used-wrongly) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong device was used instead of the correct device |
| `  2` | The wrong device was used alongside the correct device |
| `  3` | Only part of the correct device was used |
| `  4` | The device was used off-license or for an unintended purpose |
| `  5` | The device was not used as per instructions for use or was set up incorrectly |

### DrugWrongUsageDetails

 Definition: How the wrong drug was used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-drug-used-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-drug-used-4)

The code system options for [Wrong drug used](/v4/code-systems/#wrong-drug-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong drug was used instead of the correct drug |
| `  2` | The wrong drug was used as well as the correct drug |
| `  3` | Only part of the correct drug was given |

### FurnitureFittingsWrongUsageDetails

 Definition: How the wrong furniture or fittings were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-furniture-or-fittings-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-furniture-or-fittings-4)

The code system options for [Wrong furniture or fittings](/v4/code-systems/#wrong-furniture-or-fittings) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The incorrect furniture or fittings were used in place of the correct item |
| `  2` | Incorrect furniture or fittings were used as well as the correct item |
| `  3` | Only a part of the right furniture or fittings were used |

### BloodProductsWrongDetails

 Definition: How the wrong blood or blood products were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-blood-or-blood-products-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-blood-or-blood-products-4)

The code system options for [Wrong blood or blood products](/v4/code-systems/#wrong-blood-or-blood-products) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong blood or blood products were used instead of the correct ones |
| `  2` | The wrong blood or blood products were used alongside the correct ones |
| `  3` | Only part of the correct blood or blood products were used |
| `  4` | The blood or blood products was used for an unintended purpose |
| `  5` | The blood or blood products were not used as per instructions for use or were set up/given incorrectly |

### TissueOrgansWrongDetails

 Definition: How the wrong tissues or organs for transplant were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incorrect-tissues-or-organs-for-transplant-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incorrect-tissues-or-organs-for-transplant-4)

The code system options for [Incorrect tissues or organs for transplant](/v4/code-systems/#incorrect-tissues-or-organs-for-transplant) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong tissues or organs for transplant were used instead of the correct ones |
| `  2` | The wrong tissues or organs for transplant were used alongside the correct ones |
| `  3` | Only part of the correct tissues or organs for transplant were used |
| `  4` | Tissues or organs for transplant were used for an unintended purpose |
| `  5` | Tissues or organs for transplant were not used as per instructions for use |

### PeopleNotInvolvedDetails

 Definition: How the right people were not involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/not-correct-people-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/not-correct-people-4)

The code system options for [Not correct people](/v4/code-systems/#not-correct-people) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The right person was not called |
| `  2` | The right person was called but did not attend |

### PeopleOmittedActionDetails

 Definition: How people did not do something that was needed

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-did-not-do-something-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-did-not-do-something-4)

The code system options for [People did not do something](/v4/code-systems/#people-did-not-do-something) are: 

 | Code | Display |
 | --- | --- |
| `  1` | People did not know the right thing to do |
| `  2` | People knew what to do but it did not happen |

### DrugWrongDetails

 Definition: How the right drug was not used as it should have been

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/right-drug-not-used-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/right-drug-not-used-4)

The code system options for [Right drug not used](/v4/code-systems/#right-drug-not-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Drug omitted |
| `  2` | Drug dose missed |

### DeviceBrokenDetails

 Definition: How a device was broken

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-broken-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-broken-4)

The code system options for [Indication of how a device was broken](/v4/code-systems/#indication-of-how-a-device-was-broken) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The packaging was damaged making it unfit for use |
| `  2` | The device was broken or damaged before use |
| `  3` | The device broke or was damaged in use |
| `  4` | The device was dirty or unsterile |
| `  5` | The device was not stored correctly |
| `  6` | The device was out of date |
| `  7` | There was no power supply for the device/the battery was not charged/the device ran out of power during use |
| `  8` | The device had no connectivity/wifi connection |
| `  9` | The device was used as per guidance but did not perform as expected and/or caused unexpected consequences |
| ` 10` | There were no component parts/consumables available that must be used with the device |

### FurnitureFittingsBrokenDetails

 Definition: How broken furniture or fittings were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/broken-furniture-or-fittings-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/broken-furniture-or-fittings-4)

The code system options for [Broken furniture or fittings](/v4/code-systems/#broken-furniture-or-fittings) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The furniture or fittings were broken or damaged before use |
| `  2` | The furniture or fittings broke or were damaged in use |
| `  3` | The furniture or fittings were dirty rendering them unusable |
| `  4` | The furniture or fittings were not stored correctly |
| `  5` | The furniture or fittings required electricity/power and this was not available |
| `  6` | The furniture or fittings were used as per guidance but did not perform as expected |

### BloodProductsDamagedDetails

 Definition: How damaged blood or blood products were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/damaged-blood-or-blood-products-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/damaged-blood-or-blood-products-4)

The code system options for [Damaged blood or blood products](/v4/code-systems/#damaged-blood-or-blood-products) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Packaging damaged making blood or blood product unfit for use |
| `  2` | Blood or blood product found to be damaged/of insufficient quality before use. |

### TissuesOrgansDamagedDetails

 Definition: How damaged tissue or organs for transplant were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/damaged-tissues-or-organs-from-transplant-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/damaged-tissues-or-organs-from-transplant-4)

The code system options for [Damaged tissues or organs from transplant](/v4/code-systems/#damaged-tissues-or-organs-from-transplant) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The packaging/label was damaged/unclear making them unfit for use |
| `  2` | The tissues or organs for transplant were contaminated |
| `  3` | The tissues or organs for transplant had not been not stored correctly |
| `  4` | The tissues or organs for transplant were damaged or of unusable quality |
| `  5` | The tissues or organs for transplant were used as per guidance but did not perform as expected |
| `  6` | There were no consumables available that were required to transplant tissues or organs |

### ProblemDescriptionActions

 Definition: A description of the problem involving people's actions

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ProblemDescriptionDevices

 Definition: A description of the problem involving devices

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ProblemDescriptionDrugs

 Definition: A description of the problem involving drugs

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ProblemDescriptionFurnitureFittings

 Definition: A description of the problem involving furniture and fittings

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ProblemDescriptionBuiltEnvironment

 Definition: A description of the problem involving built environment

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ProblemDescriptionBlood

 Definition: A description of the problem involving blood and blood products

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ProblemDescriptionTissuesOrgans

 Definition: A description of the problem involving tissue and organs for transplant

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ProblemDescriptionSystemsSoftware

 Definition: A description of the problem involving IT systems and software

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### BloodNotUsed

 Definition: Reasons for why blood or blood products were not used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-not-used-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-not-used-4)

The code system options for [Reasons for blood or blood products not being used](/v4/code-systems/#reasons-for-blood-or-blood-products-not-being-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The required blood or blood products were not available |
| `  2` | The need for blood or blood products was not identified |

### ProblemWithBloodProducts

 Definition: What was the problem with the blood or blood products

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-products-problem-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-products-problem-4)

The code system options for [What was wrong with the blood or blood products](/v4/code-systems/#what-was-wrong-with-the-blood-or-blood-products) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The packaging/label was damaged/unclear making it unfit for use |
| `  2` | The blood or blood products were contaminated |
| `  3` | The blood or blood products were not stored correctly |
| `  4` | The blood or blood products were damaged or of unusable quality |
| `  5` | The blood or blood products were out of date |
| `  6` | The blood or blood products were used as per guidance but did not perform as expected |
| `  7` | There were no consumables available that must be used with the blood or blood products |

### TissueOrgansNotUsed

 Definition: Reasons for tissues or organs not being used when they should have been

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/tissue-organs-not-used-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/tissue-organs-not-used-4)

The code system options for [Reasons for tissue or organs not being used when they should have been](/v4/code-systems/#reasons-for-tissue-or-organs-not-being-used-when-they-should-have-been) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The required tissues or organs for transplant were not available |
| `  2` | The need for tissues or organs for transplant was not identified |

### FurnitureFittingsNotUsed

 Definition: Reasons for correct furniture and fittings not being used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/furniture-fittings-not-used-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/furniture-fittings-not-used-4)

The code system options for [Reasons for correct furniture and fittings not being used](/v4/code-systems/#reasons-for-correct-furniture-and-fittings-not-being-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The correct furniture or fittings were not available |
| `  2` | The need for furniture or fittings was not identified |

### InvolvedProcesses

 Definition: Processes involved in what went wrong

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/involved-processes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/involved-processes-4)

The code system options for [Processes involved in what went wrong](/v4/code-systems/#processes-involved-in-what-went-wrong) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Prescription |
| `  2` | Dispensing |
| `  3` | Administering |
| `  4` | Other |
| `  5` | I don't know |

### InvolvedProcessesOther

 Definition: Processes involved in what went wrong other response

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### MedicationAdministeredIncorrectly

 Definition: Reason the medication was administered incorrectly

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/medication-administered-incorrectly-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/medication-administered-incorrectly-4)

The code system options for [The reasons for medication not being prescribed or given in the right way](/v4/code-systems/#the-reasons-for-medication-not-being-prescribed-or-given-in-the-right-way) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The medication was prescribed/dispensed/administered via the wrong route |
| `  2` | The formulation/preparation of the medication was incorrectly prescribed/dispensed/administered |
| `  3` | The wrong medication was prescribed/dispensed/administered |
| `  4` | The medication was contraindicated |
| `  5` | The patient had a known allergy to the medication |
| `  6` | The patient was not given appropriate advice and counselling |
| `  7` | The medication was given using the wrong technique/method |
| `  8` | The medication was prescribed/dispensed/administered to the wrong patient |

### ProblemMedicationPackaging

 Definition: What was wrong with the medication or its packaging

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/problem-medication-or-packaging-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/problem-medication-or-packaging-4)

The code system options for [What was the problem with medication or its packaging](/v4/code-systems/#what-was-the-problem-with-medication-or-its-packaging) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The medication had been stored incorrectly/was unfit for use |
| `  2` | The medication was out of date |
| `  3` | The medication did not have the appropriate patient information leaflet |

- Type: `[x]`

## AdverseEventAgent

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-agent-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-agent-4) `Extension`

Desc: The people and or things involved in the incident

- Id: adverse-event-agent-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-agent-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-agent-4)

### InvolvedAgents

 Definition: What people and or things were involved in the event

- Cardinality

    - Min: 1

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/agent-type-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/agent-type-4)

The code system options for [Agent Type](/v4/code-systems/#agent-type) are: 

 | Code | Display |
 | --- | --- |
| `  4` | Medications |
| `  3` | Devices |
| `  9` | IT Systems or Software |
| `  6` | Built Environment |
| `  5` | Furniture or Fittings |
| `  7` | Blood or Blood products |
| `  8` | Tissues or Organs for transplant |
| ` 10` | None of the above |

### DrugsInvolved

 Definition: Drugs or medications which were involved in an Adverse Event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `String`

### FurnitureFittings

 Definition: Furniture or fittings that were involved in the event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/furniture-and-fittings-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/furniture-and-fittings-4)

The code system options for [Furniture and Fittings](/v4/code-systems/#furniture-and-fittings) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Carpets and rugs |
| `  2` | Chairs and sofas |
| `  3` | Climate control equipment and switches |
| `  4` | Decor, pictures and posters |
| `  5` | Doors and handles |
| `  6` | Light fittings and switches |
| `  7` | Personal belongings and ornaments |
| `  8` | Storage units and furniture |
| `  9` | Tables |
| ` 10` | Window dressings, curtains and blinds |
| ... | ... |

!!! info "Displaying 10 of 11"

    For full list go to [furniture-and-fittings-4](/v4/code-systems/furniture-and-fittings)




### FurnitureFittingsOther

 Definition: Other furniture or fittings

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### BuiltEnviornmentInvolved

 Definition: Elements of the built environment involved in the incident

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### InvolvedPersonsActions

 Definition: The role(s) of the people involved in the event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/human-agents-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/human-agents-4)

The code system options for [Human Agents](/v4/code-systems/#human-agents) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Healthcare staff |
| `  2` | Other patient(s) |
| `  3` | Family member or carer |
| `  4` | I don't know |
| `  5` | Other |

### InvolvedPersonsActionsOther

 Definition: Other role description

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventOutcome

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-outcome-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-outcome-4) `Extension`

Desc: The outcome of the event

- Id: adverse-event-outcome-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-outcome-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-outcome-4)

### ImmediateActions

 Definition: Details of the immediate actions taken to rescue or reduce the immediate harm to the patient

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### OutcomeType

 Definition: The type of outcome that is being recorded

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/outcome-type-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/outcome-type-4)

The code system options for [The type of outcome being reported](/v4/code-systems/#the-type-of-outcome-being-reported) are: 

 | Code | Display |
 | --- | --- |
| `  1` | A death/stillbirth/intra-uterine death that you don�t currently think is related to healthcare action or omission in any way, but requires fact-finding or notification to CQC |
| `  2` | Unplanned reattendance or readmission |
| `  3` | Unplanned admission to ITU, HDU, SCBU or NICU |
| `  5` | Return to theatre |
| ` 10` | Emergency/unplanned caesarean |
| `  7` | Crash call |
| `  4` | Safeguarding that does not involve any suspicion or acts of omission or commissions by healthcare staff, but that does require notification to adult or child protection services |
| `  9` | Postpartum haemorrhage of concern |
| ` 15` | COVID-19 related issue |

### WentWell

 Definition: Details of a positive patient safety event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventInitialEventAssessment

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-initial-event-assessment-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-initial-event-assessment-4) `Extension`

Desc: Details on reporter's initial assessment of the event, cause or factors contributing to things going wrong

- Id: adverse-event-initial-event-assessment-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-initial-event-assessment-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-initial-event-assessment-4)

### PatientSafetyIncidentHasOccurred

 Definition: To indicate if there is cause to worry or suspect patient safety incident occurred

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4)

The code system options for [Yes-No-Unknown Codes](/v4/code-systems/#yes-no-unknown-codes) are: 

 | Code | Display |
 | --- | --- |
| `  y` | Yes |
| `  n` | No |
| `  u` | I don't know |

- Type: `[x]`

## AdverseEventProcess

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-process-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-process-4) `Extension`

Desc: Details about the adverse event process

- Id: adverse-event-process-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-process-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-process-4)

### Process

 Definition: The process(es) being undertaken when something went wrong

- Cardinality

    - Min: 1

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/healthcare-process-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/healthcare-process-4)

The code system options for [Healthcare Process](/v4/code-systems/#healthcare-process) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The patient was accessing healthcare, treatment, or advice |
| `  2` | Admission or acceptance into healthcare |
| `  3` | Assessment, evaluation, examination, history-taking, investigation, testing, measurement, surveillance or screening |
| `  4` | Diagnosis or decision-making |
| `  5` | Planning or prescribing |
| `  6` | Intervention, treatment, care provision, dispensing, selection or administering |
| `  7` | Evaluation, review, monitoring or follow-up |
| `  8` | Referral, escalation or change to a different service or setting |
| `  9` | Discharge or ending a type of healthcare |
| ` 10` | Self-care or safety-netting |
| ... | ... |

!!! info "Displaying 10 of 12"

    For full list go to [healthcare-process-4](/v4/code-systems/healthcare-process)




- Type: `[x]`

## AdverseEventRiskDetails

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-risk-details-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-risk-details-4) `Extension`

Desc: Further details about a risk

- Id: adverse-event-risk-details-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-risk-details-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-risk-details-4)

### RiskDescription

 Definition: Description of the risk

- Cardinality

    - Min: 1

    - Max: 1

- Type: `String`

### RiskTheme

 Definition: The theme of the risk

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-themes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-themes-4)

The code system options for [Risk Themes](/v4/code-systems/#risk-themes) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Staffing, workload, capacity or capability of services |
| `  2` | Medical devices, including supply issues |
| `  3` | Medication, including supply issues |
| `  4` | Non-medical devices/equipment, including supply issues |
| `  5` | Healthcare buildings, fixtures and fittings |
| `  6` | Information Technology or transfer of information |
| `  7` | Problems with administrative, governance or managerial systems and processes |
| `  8` | Other |

### RiskThemeOther

 Definition: Other theme of the event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### RiskImminent

 Definition: Is the risk of death or severe harm imminent

- Cardinality

    - Min: 1

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4)

The code system options for [Yes-No-Unknown Codes](/v4/code-systems/#yes-no-unknown-codes) are: 

 | Code | Display |
 | --- | --- |
| `  y` | Yes |
| `  n` | No |
| `  u` | I don't know |

### RiskServiceArea

 Definition: What service areas could be affected by this risk

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/service-type-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/service-type-4)

The code system options for [Service Type](/v4/code-systems/#service-type) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Acute hospital services |
| `  2` | GP, walk-in service or NHS 111 |
| `  3` | Ambulance and 999 |
| `  4` | Mental health services (inpatient or community) |
| `  5` | Community hospital |
| `  6` | Community therapy |
| `  7` | Community general/district nursing and therapy |
| `  8` | Prison healthcare |
| `  9` | Community pharmacy |
| ` 10` | Community optometry |
| ... | ... |

!!! info "Displaying 10 of 15"

    For full list go to [service-type-4](/v4/code-systems/service-type)




### RiskPopulation

 Definition: What population could be affected by this risk

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### RiskTimeframe

 Definition: The timeframe in which a risk is most likely to manifest itself and cause harm

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-timeframes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-timeframes-4)

The code system options for [Risk Timeframes](/v4/code-systems/#risk-timeframes) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Months |
| `  2` | Years |
| `  3` | I don't know |
| `  4` | Other |

### RiskTimeframeOther

 Definition: Other timeframe where a risk may manifest

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventWentWell

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-went-well-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-went-well-4) `Extension`

Desc: Details of an event where patient safety went well

- Id: adverse-event-went-well-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-went-well-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-went-well-4)

### StrengthsOfCare

 Definition: The strengths of care or service delivery which went will in the provision of care

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### HowFutureOccurrence

 Definition: To indicate how the care that went well could be amplified or re-created in future

- Cardinality

    - Min: 1

    - Max: 1

- Type: `String`

### GoodCareDetectionFactor

 Definition: To determine how the example of good care came to the reporters attention

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-relationship-to-event-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-relationship-to-event-4)

The code system options for [Reporter relationship to event](/v4/code-systems/#reporter-relationship-to-event) are: 

 | Code | Display |
 | --- | --- |
| `  1` | I witnessed it but was not directly involved in the patient's care |
| `  2` | I was told about it |
| `  3` | I found it in a case note review or audit |
| `  4` | I was helping provide the care when it happened |
| `  5` | I don't want to say |
| `  6` | Other |

### GoodCareDetectionFactorOther

 Definition: Other factor which is not listed involved in noticing the example of good care

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## DetectionFactors

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/detection-factors-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/detection-factors-4) `Extension`

Desc: Factors involved in detection of a problem in care provision

- Id: detection-factors-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/detection-factors-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/detection-factors-4)

### DetectionFactors

 Definition: Factors involved in detecting the incident

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/detection-factors-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/detection-factors-4)

The code system options for [Detection Factors](/v4/code-systems/#detection-factors) are: 

 | Code | Display |
 | --- | --- |
| `  1` | By checklist |
| `  2` | Via clinical assessment/observations - staff identifying a change in patient's condition |
| `  3` | Via a test/investigation - staff identifying a change in patient's condition |
| `  4` | Via general observation - by staff (heard noise, found patient on floor etc) |
| `  5` | Via general observation - by the patient/carer/relative/friend |
| `  6` | Via general observation - by another patient |
| `  7` | Via a cry for help - from patient/carer/relative/friend/other patient |
| `  8` | By a subjective feeling/symptom reported by the patient |
| `  9` | By notification from an external agency (e.g. Police, Coroner, Media) |
| ` 10` | Via Care-staff walkaround |
| ... | ... |

!!! info "Displaying 10 of 28"

    For full list go to [detection-factors-4](/v4/code-systems/detection-factors)




### DetectionPoint

 Definition: High level detection factors

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/detection-points-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/detection-points-4)

The code system options for [Detection Factors](/v4/code-systems/#detection-factors) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Proactive risk assessment undertaken during design of a new service or significant redesign of an existing service |
| `  2` | At pre-admission patient assessment |
| `  3` | Immediately prior to care or treatment |
| `  4` | During direct care or treatment |
| `  5` | During continued care by third party agency |
| `  6` | After care or treatment has ended |
| `  7` | I don't know |
| `  8` | Other |

### DetectionPointOther

 Definition: Other detection factors

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventClassification

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-classification-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-classification-4) `Extension`

Desc: Classification details of an adverse event for reporting purposes

- Id: adverse-event-classification-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-classification-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-classification-4)

### LevelOfConcern

 Definition: Indication of how concerned the reporter feels about this adverse event given its wider implications

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/worry-scale-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/worry-scale-4)

The code system options for [Worry Scale](/v4/code-systems/#worry-scale) are: 

 | Code | Display |
 | --- | --- |
| `  5` | Very concerned |
| `  4` | Fairly concerned |
| `  3` | Not very concerned |
| `  1` | Not at all concerned |

### DutyOfCandour

 Definition: Indication of whether the adverse event meets the requirements for duty of candour

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

- Type: `[x]`

## AdverseEventReferenceMetadata

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-reference-metadata-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-reference-metadata-4) `Extension`

Desc: An extension to contain key metadata about the event

- Id: adverse-event-reference-metadata-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-reference-metadata-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-reference-metadata-4)

### ReferenceNumber

 Definition: A unique human-friendly reference number which can identify the event in addition to its id

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### FromOnlineForms

 Definition: Indicate whether the event was submitted through the online forms

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### IsAnonymous

 Definition: Indicate whether the event was submitted anonymously

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### DataSharingOptOut

 Definition: Opt out of data being shared

- Cardinality

    - Min: 1

    - Max: 1

- Type: `Boolean`

- Type: `[x]`

## AdverseEventSafetyChallenges

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-safety-challenges-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-safety-challenges-4) `Extension`

Desc: Details on safety challenges involved or contributing to the event occurring

- Id: adverse-event-safety-challenges-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-safety-challenges-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-safety-challenges-4)

### SafetyChallenges

 Definition: What safety challenges were faced in the incident

- Cardinality

    - Min: 1

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/safety-challenges-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/safety-challenges-4)

The code system options for [List of safety challenges](/v4/code-systems/#list-of-safety-challenges) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Pressure ulcers |
| `  2` | Falls |
| `  3` | Self harm |
| `  4` | Radiotherapy incident |
| `  5` | Healthcare Acquired Infection |
| `  6` | None of the above |

### RadiotherapyIncidentCode

 Definition: To identify the radiotherapy incident classification, severity, pathway and causative factors

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-patient-4]()
Reference

Desc: A profile for the patient subject used by the NHS Improvement Patient Safety Incident Management System

- Id: adverse-event-patient-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-patient-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-patient-4)

### PatientInformation

- Cardinality

    - Min: 0

    - Max: 100

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-information-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-information-4) `Extension`

Desc: A collection of patient details relevant to adverse events

- Id: patient-information-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-information-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-information-4)

#### PhysicalHarm

 Definition: Level of physical harm sustained by the patient

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/level-of-physical-harm-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/level-of-physical-harm-4)

The code system options for [Level of Physical Harm](/v4/code-systems/#level-of-physical-harm) are: 

 | Code | Display |
 | --- | --- |
| `  5` | No physical harm |
| `  4` | Low physical harm |
| `  3` | Moderate physical harm |
| `  2` | Severe physical harm |
| `  1` | Fatal |

#### PsychologicalHarm

 Definition: Level of psychological harm sustained by the patient

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/level-of-psychological-harm-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/level-of-psychological-harm-4)

The code system options for [Level of Psychological Harm](/v4/code-systems/#level-of-psychological-harm) are: 

 | Code | Display |
 | --- | --- |
| `  4` | No psychological harm |
| `  3` | Low psychological harm |
| `  2` | Moderate psychological harm |
| `  1` | Severe psychological harm |

#### ClinicalOutcome

 Definition: Clinical outcome for the patient

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### AgeAtTimeOfIncident

 Definition: The patient's age at the time of the incident

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Integer`

#### AgeYears

 Definition: The patient's estimated age when the exact age is unknown

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/age-brackets-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/age-brackets-4)

The code system options for [Age Brackets](/v4/code-systems/#age-brackets) are: 

 | Code | Display |
 | --- | --- |
| `  1` | 0-14 days |
| `  2` | 15-28 days |
| `  3` | 1-11 months |
| `  4` | 1-4 years |
| `  5` | 5-9 years |
| `  6` | 10-15 years |
| `  7` | 16 and 17 years |
| `  8` | 18-25 years |
| `  9` | 26-45 years |
| ` 10` | 46-65 years |
| ... | ... |

!!! info "Displaying 10 of 12"

    For full list go to [age-brackets-4](/v4/code-systems/age-brackets)




#### Gender

 Definition: The gender of the patient

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/gender-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/gender-4)

The code system options for [The gender of a person used for administrative purposes](/v4/code-systems/#the-gender-of-a-person-used-for-administrative-purposes) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Female |
| `  2` | Male |
| `  3` | I don't know |
| `  4` | Withheld, not specified or other |

#### PatientSequence

 Definition: Sequence id for the patient details for sorting purposes

- Cardinality

    - Min: 1

    - Max: 1

- Type: `Integer`

#### StrengthOfAssociation

 Definition: Extent to which the problem was associated with the patient outcome

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/strength-of-association-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/strength-of-association-4)

The code system options for [Strength of Association](/v4/code-systems/#strength-of-association) are: 

 | Code | Display |
 | --- | --- |
| `  6` | The incident caused the outcome |
| `  5` | The incident probably affected the outcome |
| `  4` | The incident possibly affected the outcome |
| `  3` | The incident was not related to the outcome |
| `  2` | I don't know |

- Type: `[x]`

Target profile: [http://hl7.org/fhir/StructureDefinition/Organization]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Organization

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Organization]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Organization

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Practitioner]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Practitioner

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Organization]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Organization

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Patient]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Patient

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/RelatedPerson]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/RelatedPerson

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Condition]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Condition

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-location-4]()
Reference

Desc: A profile describing the location where an AdverseEvent has taken place

- Id: adverse-event-location-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-location-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-location-4)

### LocationDetails

- Cardinality

    - Min: 1

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/location-details-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/location-details-4) `Extension`

Desc: Further details about an adverse event location

- Id: location-details-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/location-details-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/location-details-4)

#### LocationKnown

 Definition: The location where there event took place

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4)

The code system options for [Yes-No-Unknown Codes](/v4/code-systems/#yes-no-unknown-codes) are: 

 | Code | Display |
 | --- | --- |
| `  y` | Yes |
| `  n` | No |
| `  u` | I don't know |

#### Organisation

 Definition: An organisation that was involved in the adverse event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-4)

The code system options for [ODS Codes](/v4/code-systems/#ods-codes) are: 

 | Code | Display |
 | --- | --- |
| `P87657` | (IRLAM) SALFORD CARE CTRS MEDICAL PRACTI |
| `N84035` | 15 SEFTON ROAD |
| `601201A` | Abersychan Pharmacy |
| `Y01010` | BCH COMMUNITY RESPIRATORY TEAM |
| `07N` | NHS BEXLEY CCG |
| `15E` | NHS BIRMINGHAM AND SOLIHULL CCG |
| `00Q` | NHS BLACKBURN WITH DARWEN CCG |
| `00R` | NHS BLACKPOOL CCG |
| `00T` | NHS BOLTON CCG |
| `Y03271` | NHS BP DERMATOLOGY CLINIC |
| ... | ... |

!!! info "Displaying 10 of 16496"

    For full list go to [ods-codes-4](/v4/code-systems/ods-codes)




#### OrganisationOther

 Definition: Other involved organisation

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### ServiceArea

 Definition: Service areas involved in the event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/service-type-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/service-type-4)

The code system options for [Service Type](/v4/code-systems/#service-type) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Acute hospital services |
| `  2` | GP, walk-in service or NHS 111 |
| `  3` | Ambulance and 999 |
| `  4` | Mental health services (inpatient or community) |
| `  5` | Community hospital |
| `  6` | Community therapy |
| `  7` | Community general/district nursing and therapy |
| `  8` | Prison healthcare |
| `  9` | Community pharmacy |
| ` 10` | Community optometry |
| ... | ... |

!!! info "Displaying 10 of 15"

    For full list go to [service-type-4](/v4/code-systems/service-type)




#### LocationWithinService

 Definition: The location within the service where an adverse event occurred

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incident-location-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incident-location-4)

The code system options for [Incident Location](/v4/code-systems/#incident-location) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Public place |
| `  2` | Private home |
| `  3` | Care home |
| `  4` | Hospital |
| `  5` | Another sort of healthcare building |
| `  6` | Ambulance or other healthcare vehicle |
| `  7` | Prison |
| `  8` | No specific location |
| `  9` | I don't know |

#### ResponsibleSpecialty

 Definition: Specialty caring for the patient at the time the problem occurred

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/specialty-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/specialty-4)

The code system options for [Specialty](/v4/code-systems/#specialty) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Accident and emergency |
| `  2` | Acute internal medicine |
| `  3` | Adult mental illness |
| `  4` | Allied health professional episode |
| `  5` | Anaesthetics |
| `  6` | Audiological medicine |
| `  7` | Blood transfusion |
| `  8` | Breast surgery |
| `  9` | Burns surgery |
| ` 10` | Cardiology |
| ... | ... |

!!! info "Displaying 10 of 101"

    For full list go to [specialty-4](/v4/code-systems/specialty)




#### ResponsibleSpecialtyOther

 Definition: Other responsible specialty

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### IdentifiedLocation

 Definition: Location where the event was identified

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-4)

The code system options for [ODS Codes](/v4/code-systems/#ods-codes) are: 

 | Code | Display |
 | --- | --- |
| `P87657` | (IRLAM) SALFORD CARE CTRS MEDICAL PRACTI |
| `N84035` | 15 SEFTON ROAD |
| `601201A` | Abersychan Pharmacy |
| `Y01010` | BCH COMMUNITY RESPIRATORY TEAM |
| `07N` | NHS BEXLEY CCG |
| `15E` | NHS BIRMINGHAM AND SOLIHULL CCG |
| `00Q` | NHS BLACKBURN WITH DARWEN CCG |
| `00R` | NHS BLACKPOOL CCG |
| `00T` | NHS BOLTON CCG |
| `Y03271` | NHS BP DERMATOLOGY CLINIC |
| ... | ... |

!!! info "Displaying 10 of 16496"

    For full list go to [ods-codes-4](/v4/code-systems/ods-codes)




#### IdentifiedLocationOther

 Definition: Other location where the event was identified

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### LocationAtRisk

 Definition: The location where a risk is present

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-location-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-location-4)

The code system options for [Risk location](/v4/code-systems/#risk-location) are: 

 | Code | Display |
 | --- | --- |
| `  1` | My organisation |
| `  2` | A different organisation |
| `  3` | The risk is widespread |
| `  4` | I don't know |

#### RiskIdentifiedLocation

 Definition: The location where a risk was identified

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/location-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/location-4)

The code system options for [Location](/v4/code-systems/#location) are: 

 | Code | Display |
 | --- | --- |
| `  1` | My organisation |
| `  2` | A different organisation |
| `  3` | I don't know |

- Type: `[x]`

Target profile: [http://hl7.org/fhir/StructureDefinition/Organization]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Organization

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Location]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Location

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Endpoint]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Endpoint

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-practitioner-4]()
Reference

Desc: A profile for the practitioner who records an AdverseEvent as used by the NHS Improvement Patient Safety Incident Management System

- Id: adverse-event-practitioner-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-practitioner-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-practitioner-4)

### PractitionerDetails

- Cardinality

    - Min: 1

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/practitioner-details-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/practitioner-details-4) `Extension`

Desc: Information about the practitioner that reported an adverse event

- Id: practitioner-details-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/practitioner-details-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/practitioner-details-4)

#### ReporterType

 Definition: Who the reporter of an adverse event is

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-type-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-type-4)

The code system options for [Reporter Type](/v4/code-systems/#reporter-type) are: 

 | Code | Display |
 | --- | --- |
| `  1` | I am the affected patient |
| `  2` | I am a friend/carer/relative of the patient |
| `  3` | I am a member of staff |
| `  4` | I am none of the above (please give details) |
| `  5` | Other |

#### ReporterTypeOther

 Definition: Other reporter type

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### ReporterRole

 Definition: The role of the reporter

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/staff-type-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/staff-type-4)

The code system options for [Staff type](/v4/code-systems/#staff-type) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Additional clinical services staff, including ambulance services and pharmacy |
| `  2` | Additional professional, scientific and technical staff, including social care |
| `  3` | Allied health professional |
| `  4` | Doctor or dentist |
| `  5` | Nurse or midwife |
| `  6` | Administrative and clerical staff |
| `  7` | Estates and ancillary staff |
| `  8` | Supplementary roles, including voluntary services |
| `  9` | Other |

#### ReporterRoleOther

 Definition: Other role

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### ReporterInvolvement

 Definition: How was the reporter involved in the event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-relationship-to-event-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-relationship-to-event-4)

The code system options for [Reporter relationship to event](/v4/code-systems/#reporter-relationship-to-event) are: 

 | Code | Display |
 | --- | --- |
| `  1` | I witnessed it but was not directly involved in the patient's care |
| `  2` | I was told about it |
| `  3` | I found it in a case note review or audit |
| `  4` | I was helping provide the care when it happened |
| `  5` | I don't want to say |
| `  6` | Other |

#### ReporterInvolvementOther

 Definition: Other involvement in the event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### ReporterContact

 Definition: Contact details for the reporter

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### ReporterOrganisation

 Definition: The organisation from which the report is being made

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-4)

The code system options for [ODS Codes](/v4/code-systems/#ods-codes) are: 

 | Code | Display |
 | --- | --- |
| `P87657` | (IRLAM) SALFORD CARE CTRS MEDICAL PRACTI |
| `N84035` | 15 SEFTON ROAD |
| `601201A` | Abersychan Pharmacy |
| `Y01010` | BCH COMMUNITY RESPIRATORY TEAM |
| `07N` | NHS BEXLEY CCG |
| `15E` | NHS BIRMINGHAM AND SOLIHULL CCG |
| `00Q` | NHS BLACKBURN WITH DARWEN CCG |
| `00R` | NHS BLACKPOOL CCG |
| `00T` | NHS BOLTON CCG |
| `Y03271` | NHS BP DERMATOLOGY CLINIC |
| ... | ... |

!!! info "Displaying 10 of 16496"

    For full list go to [ods-codes-4](/v4/code-systems/ods-codes)




#### ReporterOrganisationOther

 Definition: Other reporting organisation

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

#### WhyAnonymous

 Definition: Indication of why the reporter has logged the event anonymously

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/anonymity-reasons-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/anonymity-reasons-4)

The code system options for [Reasons for recording the event anonymously](/v4/code-systems/#reasons-for-recording-the-event-anonymously) are: 

 | Code | Display |
 | --- | --- |
| `  1` | To save time |
| `  2` | I forgot my account details |
| `  3` | I don't see any benefit in signing in to my account |
| `  4` | I am concerned that what I say might be used against me by my organisation or employer |
| `  5` | I am concerned that what I say might be used against me by another organisation |
| `  6` | I am concerned that what I say might negatively affect my reputation or career |
| `  7` | I am concerned that colleagues may find out what I have said |
| `  8` | Other |

#### WhyAnonymousOther

 Definition: Other reason for anonymous reporting

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

Target profile: [http://hl7.org/fhir/StructureDefinition/Organization]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Organization

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Practitioner]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Practitioner

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Device]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Device

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-medication-4]()
Reference

Desc: This resource is primarily used for the identification and definition of a medication. It covers the ingredients and the packaging for a medication.

- Id: adverse-event-medication-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-medication-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-medication-4)

### MedicationAdministration

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/medication-administration-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/medication-administration-4) `Extension`

Desc: Information on the delivery of a medication

- Id: medication-administration-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/medication-administration-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/medication-administration-4)

#### MedicationAdministration

 Definition: Was a the medication administered by using a device

- Cardinality

    - Min: 1

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-4)

The code system options for [Yes-No-Unknown Codes](/v4/code-systems/#yes-no-unknown-codes) are: 

 | Code | Display |
 | --- | --- |
| `  y` | Yes |
| `  n` | No |
| `  u` | I don't know |

- Type: `[x]`

Target profile: [http://hl7.org/fhir/StructureDefinition/Organization]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Organization

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Substance]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Substance

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Medication]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Medication

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Medication]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Medication

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Nested profile: [http://hl7.org/fhir/StructureDefinition/SimpleQuantity](http://hl7.org/fhir/StructureDefinition/SimpleQuantity) `Quantity`

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/SimpleQuantity

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-4]()
Reference

Desc: This resource identifies an instance or a type of a manufactured item that is used in the provision of healthcare without being substantially changed through that activity. The device may be a medical or non-medical device. Medical devices include durable (reusable) medical equipment, implantable devices, as well as disposable equipment used for diagnostic, treatment, and research for healthcare and public health. Non-medical devices may include items such as a machine, cellphone, computer, application, etc.

- Id: adverse-event-device-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-4)

### AdverseEventDeviceDetails

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-details-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-details-4) `Extension`

Desc: Further details about a device which is related to an adverse event

- Id: adverse-event-device-details-4

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-details-4](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-details-4)

#### DeviceType

 Definition: The type of medical device that was involved in an incident

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-type-4](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-type-4)

The code system options for [Device Type](/v4/code-systems/#device-type) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Administration and giving sets |
| `  2` | Anaesthetic and breathing masks and tubing |
| `  3` | Anaesthetic machines |
| `  4` | Autoclaves and decontamination equipment |
| `  5` | Bath and shower aids |
| `  6` | Batteries and generators for medical device power delivery |
| `  7` | Beds, side rails and mattresses |
| `  8` | Blood fridges |
| `  9` | Blood gas analysers and accessories, including blood gas syringe or needle sets |
| ` 10` | Blood pressure equipment |
| ... | ... |

!!! info "Displaying 10 of 88"

    For full list go to [device-type-4](/v4/code-systems/device-type)




#### DeviceTypeOther

 Definition: Other device type

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

Target profile: [http://hl7.org/fhir/StructureDefinition/Patient]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Patient

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Organization]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Organization

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Location]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Location

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Practitioner]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Practitioner

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/PractitionerRole]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/PractitionerRole

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Condition]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Condition

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Observation]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Observation

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/AllergyIntolerance]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/AllergyIntolerance

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Immunization]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Immunization

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/Procedure]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/Procedure

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/DocumentReference]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/DocumentReference

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



Target profile: [http://hl7.org/fhir/StructureDefinition/ResearchStudy]()
Reference

- Profile URI not loaded: http://hl7.org/fhir/StructureDefinition/ResearchStudy

!!! failure "Error occurred processing profile"

    An error occurred, details as follows: 

    > Operation resulted in a redirection response (Redirect). OperationOutcome: Overall result: FAILURE (1 errors and 0 warnings)

    > [ERROR] (no details)(further diagnostics: Endpoint returned a body with contentType 'text/html', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?)

    > .



