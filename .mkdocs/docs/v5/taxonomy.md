Taxonomy document for AdverseEvent v5

Desc: A profile for patient safety events used by the NHS Improvement Patient Safety Incident Management System

- Id: patient-safety-adverse-event-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-safety-adverse-event-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-safety-adverse-event-5)

## AdverseEventEstimatedDate

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-estimated-date-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-estimated-date-5) `Extension`

Desc: Information about the estimated date/time of the event

- Id: adverse-event-estimated-date-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-estimated-date-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-estimated-date-5)

### IncidentOccurredToday

 Definition: Indication of whether the event occurred today

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5)

The code system options for [Yes-No-Unknown Codes](../code-systems/#yes-no-unknown-codes) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/time-of-incident-brackets-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/time-of-incident-brackets-5)

The code system options for [Time of Incident Brackets](../code-systems/#time-of-incident-brackets) are: 

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

## AdverseEventAgent

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-agent-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-agent-5) `Extension`

Desc: The people and or things involved in the incident

- Id: adverse-event-agent-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-agent-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-agent-5)

### InvolvedAgents

 Definition: What people and or things were involved in the event

- Cardinality

    - Min: 1

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/agent-type-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/agent-type-5)

The code system options for [Agent Type](../code-systems/#agent-type) are: 

 | Code | Display |
 | --- | --- |
| `  4` | Medications |
| `  3` | Devices |
| `  9` | IT Systems or Software |
| ` 13` | Buildings or Infrastructure |
| ` 14` | Estates Services |
| ` 11` | Blood |
| ` 12` | Blood products |
| `  8` | Tissues or Organs for transplant |
| ` 10` | None of the above |

### DrugsInvolved

 Definition: Drugs or medications which were involved in an Adverse Event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `String`

### InvolvedPersonsActions

 Definition: The role(s) of the people involved in the event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/human-agents-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/human-agents-5)

The code system options for [Human Agents](../code-systems/#human-agents) are: 

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

### BuildingsInfrastructure

 Definition: Buildings or infrastructure that were involved in the event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/buildings-or-infrastructure-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/buildings-or-infrastructure-5)

The code system options for [Buildings or Infrastructure](../code-systems/#buildings-or-infrastructure) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Areas under construction, including scaffolding |
| `  2` | Fire prevention and response |
| `  3` | Medical gas supply |
| `  4` | Heating and ventilation, including overheating |
| `  5` | Lighting |
| `  6` | Water supply |
| `  7` | Power supply |
| `  8` | Non-medical electrical equipment |
| `  9` | Building access and car parking |
| ` 10` | Lifts and pulley systems |
| ... | ... |

!!! info "Displaying 10 of 16"

    For full list go to [buildings-or-infrastructure-5](../code-systems/buildings-or-infrastructure)




### BuildingsInfrastructureOther

 Definition: Other buildings or infrastructure

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### EstatesServices

 Definition: Estates services that were involved in the event

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/estates-services-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/estates-services-5)

The code system options for [Estates Services](../code-systems/#estates-services) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Infection control relating to the built environment |
| `  2` | Hospital food services |
| `  3` | Cleaning and cleanliness |
| `  4` | Linen and laundry services |
| `  5` | Pest control |
| `  6` | Decontamination of surgical instruments |
| `  7` | Healthcare waste management |
| `  8` | Non-emergency patient transport |
| `  9` | Other |

### EstatesServicesOther

 Definition: Other estates services

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### SabreReportNumber

 Definition: Sabre reporting reference number

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### ShotReportNumber

 Definition: Shot reporting reference number

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### NhsbtReportNumber

 Definition: NHSBT reporting reference number

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### YellowCardReference

 Definition: Yellow card reference number

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventOutcome

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-outcome-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-outcome-5) `Extension`

Desc: The outcome of the event

- Id: adverse-event-outcome-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-outcome-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-outcome-5)

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/outcome-type-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/outcome-type-5)

The code system options for [The type of outcome being reported](../code-systems/#the-type-of-outcome-being-reported) are: 

 | Code | Display |
 | --- | --- |
| `  1` | A death/stillbirth/intra-uterine death that you don't currently think is related to healthcare action or omission in any way, but requires fact-finding or notification to CQC |
| `  2` | Unplanned reattendance or readmission |
| `  3` | Unplanned admission to ITU, HDU, SCBU or NICU |
| `  5` | Return to theatre |
| ` 10` | Emergency/unplanned caesarean |
| `  7` | Crash call |
| `  4` | Safeguarding that does not involve any suspicion or acts of omission or commissions by healthcare staff, but that does require notification to adult or child protection services |
| `  9` | Postpartum haemorrhage of concern |

### WentWell

 Definition: Details of a positive patient safety event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventProcess

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-process-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-process-5) `Extension`

Desc: Details about the adverse event process

- Id: adverse-event-process-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-process-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-process-5)

### Process

 Definition: The process(es) being undertaken when something went wrong

- Cardinality

    - Min: 1

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/healthcare-process-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/healthcare-process-5)

The code system options for [Healthcare Process](../code-systems/#healthcare-process) are: 

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

    For full list go to [healthcare-process-5](../code-systems/healthcare-process)




- Type: `[x]`

## AdverseEventRiskDetails

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-risk-details-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-risk-details-5) `Extension`

Desc: Further details about a risk

- Id: adverse-event-risk-details-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-risk-details-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-risk-details-5)

### RiskDescription

 Definition: Description of the risk

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### RiskTheme

 Definition: The theme of the risk

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-themes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-themes-5)

The code system options for [Risk Themes](../code-systems/#risk-themes) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5)

The code system options for [Yes-No-Unknown Codes](../code-systems/#yes-no-unknown-codes) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/service-type-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/service-type-5)

The code system options for [Service Type](../code-systems/#service-type) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Acute, general or specialist services (including inpatient, ED, outpatient and 'outsourced hospital care') |
| ` 19` | Maternity services (inpatient or community) |
| ` 17` | GP including out-of-hours services and minor injury units |
| ` 18` | NHS 111 |
| `  3` | Ambulance and 999 |
| `  4` | Mental health services (inpatient or community) |
| `  6` | Community therapy services |
| `  7` | Community general/district nursing |
| `  8` | Prison healthcare |
| `  9` | Community pharmacy |
| ... | ... |

!!! info "Displaying 10 of 17"

    For full list go to [service-type-5](../code-systems/service-type)




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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-timeframes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-timeframes-5)

The code system options for [Risk Timeframes](../code-systems/#risk-timeframes) are: 

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

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-went-well-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-went-well-5) `Extension`

Desc: Details of an event where patient safety went well

- Id: adverse-event-went-well-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-went-well-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-went-well-5)

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-relationship-to-event-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-relationship-to-event-5)

The code system options for [Reporter relationship to event](../code-systems/#reporter-relationship-to-event) are: 

 | Code | Display |
 | --- | --- |
| `  1` | I witnessed it but was not directly involved in the patient's care |
| `  2` | I was told about it |
| `  3` | I found it in a case record review or audit |
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

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/detection-factors-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/detection-factors-5) `Extension`

Desc: Factors involved in detection of a problem in care provision

- Id: detection-factors-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/detection-factors-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/detection-factors-5)

### DetectionPoint

 Definition: High level detection factors

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/detection-points-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/detection-points-5)

The code system options for [Detection Factors](../code-systems/#detection-factors) are: 

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

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-classification-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-classification-5) `Extension`

Desc: Classification details of an adverse event for reporting purposes

- Id: adverse-event-classification-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-classification-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-classification-5)

### LevelOfConcern

 Definition: Indication of how concerned the reporter feels about this adverse event given its wider implications

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/worry-scale-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/worry-scale-5)

The code system options for [Worry Scale](../code-systems/#worry-scale) are: 

 | Code | Display |
 | --- | --- |
| `  5` | Very concerned |
| `  4` | Fairly concerned |
| `  3` | Not very concerned |
| `  1` | Not at all concerned |

### PatientSafetyIncidentHasOccurred

 Definition: To indicate if there is cause to worry or suspect patient safety incident occurred

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5)

The code system options for [Yes-No-Unknown Codes](../code-systems/#yes-no-unknown-codes) are: 

 | Code | Display |
 | --- | --- |
| `  y` | Yes |
| `  n` | No |
| `  u` | I don't know |

- Type: `[x]`

## AdverseEventReferenceMetadata

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-reference-metadata-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-reference-metadata-5) `Extension`

Desc: An extension to contain key metadata about the event

- Id: adverse-event-reference-metadata-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-reference-metadata-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-reference-metadata-5)

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

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-safety-challenges-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-safety-challenges-5) `Extension`

Desc: Details on safety challenges involved or contributing to the event occurring

- Id: adverse-event-safety-challenges-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-safety-challenges-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-safety-challenges-5)

### SafetyChallenges

 Definition: What safety challenges were faced in the incident

- Cardinality

    - Min: 1

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/safety-challenges-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/safety-challenges-5)

The code system options for [List of safety challenges](../code-systems/#list-of-safety-challenges) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Pressure ulcers |
| `  2` | Falls |
| `  3` | Self harm |
| `  4` | Radiotherapy incident |
| `  5` | Healthcare associated infection |
| `  7` | Screening services incident |
| `  6` | None of the above |

### RadiotherapyIncidentCode

 Definition: To identify the radiotherapy incident classification, severity, pathway and causative factors

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### MarvinReferenceNumber

 Definition: Marvin reference number

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventGovernance

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-governance-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-governance-5) `Extension`

Desc: Governance information relating to the adverse event, including notifiable bodies

- Id: adverse-event-governance-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-governance-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-governance-5)

### DutyOfCandour

 Definition: Indication of whether the adverse event meets the requirements for duty of candour

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### CqcNotify

 Definition: Indication of whether the adverse event meets the criteria for CQC notification

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### CqcCriteria

 Definition: Identification of which CQC criteria the adverse event meets

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/cqc-criteria-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/cqc-criteria-5)

The code system options for [CQC Criteria](../code-systems/#cqc-criteria) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Death of a service user |
| `  2` | Serious injury of a service user |
| `  3` | Abuse or allegations of abuse |
| `  4` | Events that stop or may stop a service running |

### LocalAuthoritySafeguarding

 Definition: Indication of whether the adverse event has been referred to the Local Authority Safeguarding team

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### NeverEvent

 Definition: Indication of whether the adverse event meets the criteria for being a Never Event

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### SeriousIncident

 Definition: Indication of whether the adverse event meets the criteria for being a Serious Incident

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### HsibNotify

 Definition: Indication of whether the adverse event meets the criteria for HSIB notification

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### NeverEventType

 Definition: Indication of the type of never event this event is classified as

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/never-event-type-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/never-event-type-5)

The code system options for [Never Event Type](../code-systems/#never-event-type) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Wrong site surgery |
| `  2` | Wrong implant/prosthesis |
| `  3` | Retained foreign object post procedure |
| `  4` | Mis-selection of a strong potassium solution |
| `  5` | Administration of medication by the wrong route |
| `  6` | Overdose of insulin due to abbreviations or incorrect device |
| `  7` | Overdose of methotrexate for non-cancer treatment |
| `  8` | Mis-selection of high strength midazolam during conscious sedation |
| `  9` | Failure to install functional collapsible shower or curtain rails |
| ` 10` | Falls from poorly restricted windows |
| ... | ... |

!!! info "Displaying 10 of 15"

    For full list go to [never-event-type-5](../code-systems/never-event-type)




### DesignationsMentalHealth

 Definition: Indication of whether the patient has been sectioned under the Mental Health Act

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

### DeprivationOfLiberty

 Definition: Indication of whether the patient is subject to a Deprivation of Liberty Safeguard

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Boolean`

- Type: `[x]`

## AdverseEventProblemBuildingsInfrastructure

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-buildings-infrastructure-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-buildings-infrastructure-5) `Extension`

Desc: Information about problems with the buildings or infrastructure involved

- Id: adverse-event-problem-buildings-infrastructure-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-buildings-infrastructure-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-buildings-infrastructure-5)

### BuildingsInfrastructureInvolved

 Definition: How the buildings or infrastructure was involved

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/buildings-or-infrastructure-involved-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/buildings-or-infrastructure-involved-5)

The code system options for [Buildings or Infrastructure Involved](../code-systems/#buildings-or-infrastructure-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Buildings or infrastructure were used or present when they should not have been |
| `  2` | Buildings or infrastructure were not used or present when they should have been |
| `  3` | The wrong buildings or infrastructure were used or present |
| `  4` | Buildings or infrastructure were broken or not fit for purpose |
| `  5` | Other |
| `  6` | I don't know |

### BuildingsInfrastructureNotUsed

 Definition: Why buildings or infrastructure was not used

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/buildings-or-infrastructure-not-used-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/buildings-or-infrastructure-not-used-5)

The code system options for [Buildings or Infrastructure Not Used](../code-systems/#buildings-or-infrastructure-not-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The correct buildings or infrastructure were not available |
| `  2` | The need for buildings or infrastructure was not identified |

### WrongBuildingsInfrastructure

 Definition: How the wrong buildings or infrastructure were used

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-buildings-or-infrastructure-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-buildings-or-infrastructure-5)

The code system options for [Wrong Buildings or Infrastructure](../code-systems/#wrong-buildings-or-infrastructure) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The incorrect buildings or infrastructure were used in place of the correct ones |
| `  2` | Incorrect buildings or infrastructure were used as well as the correct ones |
| `  3` | Only a part of the right buildings or infrastructure were used |

### BuildingsInfrastructureProblem

 Definition: The problem with buildings or infrastructure

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventProblemEstatesServices

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-estates-services-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-estates-services-5) `Extension`

Desc: Information about problems with the estates services involved

- Id: adverse-event-problem-estates-services-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-estates-services-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-estates-services-5)

### EstatesServicesInvolved

 Definition: How estates services were involved

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/estates-services-involved-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/estates-services-involved-5)

The code system options for [Estates Services Involved](../code-systems/#estates-services-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Estates services were over-used or used when they should not have been |
| `  2` | Estates services were not used or present when they should have been |
| `  3` | The wrong estates services were used or present |
| `  4` | Estates services were not fit for purpose |
| `  5` | Other |
| `  6` | I don't know |

### EstatesServicesNotUsed

 Definition: Why the estates services were not used

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/estates-services-not-used-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/estates-services-not-used-5)

The code system options for [Estates Services Not Used](../code-systems/#estates-services-not-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The correct estates services were not available |
| `  2` | The need for estates services was not identified |

### WrongEstatesServices

 Definition: How the wrong estates services were involved

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-estates-services-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-estates-services-5)

The code system options for [Wrong Estates Services](../code-systems/#wrong-estates-services) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The incorrect estates services were used in place of the correct ones |
| `  2` | Incorrect estates services were used as well as the correct ones |
| `  3` | Only a part of the right estates services were used |

### EstatesServicesProblem

 Definition: The problem with the estates services

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventProblemBlood

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-blood-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-blood-5) `Extension`

Desc: Information about problems with blood involved

- Id: adverse-event-problem-blood-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-blood-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-blood-5)

### BloodInvolved

 Definition: How blood was involved

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-involved-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-involved-5)

The code system options for [Blood Involved](../code-systems/#blood-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too much blood was used |
| `  2` | Too little blood was used |
| `  3` | The wrong blood was used in place of the correct blood |
| `  4` | Blood was not used when it should have been |
| `  5` | Blood was available but damaged or not fit for use |
| `  6` | Other |
| `  7` | I don't know |

### TooMuchBloodUsed

 Definition: How too much blood was used

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-blood-used-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-blood-used-5)

The code system options for [Too Much Blood Used](../code-systems/#too-much-blood-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too great a quantity of blood was used |
| `  2` | Blood was used when it was not required |
| `  3` | Blood was used too soon |
| `  4` | Blood was used after its use should have been withdrawn |
| `  5` | Blood was given too quickly |

### TooLittleBloodUsed

 Definition: How too little blood was used

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-blood-used-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-blood-used-5)

The code system options for [Too Little Blood Used](../code-systems/#too-little-blood-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Not enough blood was given |
| `  2` | There was a delay in using blood |
| `  3` | Blood was not given for long enough |
| `  4` | Blood was given too slowly |

### WrongBlood

 Definition: How the wrong blood was used

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-blood-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-blood-5)

The code system options for [Wrong Blood](../code-systems/#wrong-blood) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong blood was used instead of the correct blood |
| `  2` | The wrong blood was used alongside the correct blood |
| `  3` | The blood was used for an unintended purpose |
| `  4` | The blood was not used as per instructions for use or was set up/given incorrectly |

### BloodWasNotUsed

 Definition: Why blood was not used

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-was-not-used-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-was-not-used-5)

The code system options for [Blood Was Not Used](../code-systems/#blood-was-not-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The required blood was not available |
| `  2` | The need for blood was not identified |

### DamagedBlood

 Definition: How the blood was damaged or unfit for purpose

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-damaged-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-damaged-5)

The code system options for [Blood Damaged](../code-systems/#blood-damaged) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The packaging was damaged |
| `  2` | The labelling was damaged |
| `  3` | The blood had not been stored correctly |
| `  4` | The blood had not been handled or transported correctly |
| `  5` | The blood was out of date |

### BloodProblem

 Definition: Problem with blood

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventProblemBloodProducts

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-blood-products-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-blood-products-5) `Extension`

Desc: Information about problems with the blood products involved

- Id: adverse-event-problem-blood-products-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-blood-products-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-blood-products-5)

### BloodProductsDetails

 Definition: Details of the blood products involved

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### BloodProductsBrand

 Definition: Details of the brand of blood products involved

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### BloodProductsBatch

 Definition: Details of the batch of blood products involved

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### BloodProductsInvolved

 Definition: How blood products were involved

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-products-involved-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-products-involved-5)

The code system options for [Blood Products Involved](../code-systems/#blood-products-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too great an amount of blood products were used |
| `  2` | Too small an amount of blood products were used |
| `  3` | The wrong blood products were used in place of the correct ones |
| `  4` | Blood products were not used when they should have been |
| `  5` | Blood products were available but damaged or not fit for use |
| `  6` | Other |
| `  7` | I don't know |

### TooMuchBloodProducts

 Definition: How too much blood products were involved

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-blood-products-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-blood-products-5)

The code system options for [Too Much Blood Products](../code-systems/#too-much-blood-products) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too great a quantity of blood products were used |
| `  2` | Blood products were used when they were not required |
| `  3` | Blood products were used too soon |
| `  4` | Blood products were used after their use should have been withdrawn |
| `  5` | Blood products were given too quickly |

### TooLittleBloodProducts

 Definition: How too little blood products were involved

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-blood-products-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-blood-products-5)

The code system options for [Too Little Blood Products](../code-systems/#too-little-blood-products) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too little blood products were given |
| `  2` | There was a delay in using blood products |
| `  3` | Blood products were not given for long enough |
| `  4` | Blood products were given too slowly |

### WrongBloodProducts

 Definition: How the wrong blood products were involved

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-blood-products-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/wrong-blood-products-5)

The code system options for [Wrong Blood Products](../code-systems/#wrong-blood-products) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong blood products were used instead of the correct ones |
| `  2` | The wrong blood products were used alongside the correct ones |
| `  3` | Only some of the correct blood products were used |
| `  4` | The blood products were used for an unintended purpose |
| `  5` | The blood products were not used as per instructions for use or were set up/given incorrectly |

### BloodProductsNotUsed

 Definition: Why blood products were not used

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-products-not-used-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-products-not-used-5)

The code system options for [Blood Products Not Used](../code-systems/#blood-products-not-used) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The required blood products were not available |
| `  2` | The need for blood products were not identified |

### DamagedBloodProducts

 Definition: How blood products were damaged or unfit for purpose

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-products-damaged-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/blood-products-damaged-5)

The code system options for [Blood Products Damaged](../code-systems/#blood-products-damaged) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The packaging was damaged |
| `  2` | The labelling was damaged |
| `  3` | The blood products had not been stored correctly |
| `  4` | The blood products had not been handled or transported correctly |
| `  5` | The blood products were out of date |

### BloodProductsProblem

 Definition: Problem with blood products

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventProblemMedication

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-medication-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-medication-5) `Extension`

Desc: Information about problems with medications involved

- Id: adverse-event-problem-medication-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-medication-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-medication-5)

### DrugReaction

 Definition: Indication of whether an adverse event was due to an adverse drug reaction

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yellow-card-criteria-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yellow-card-criteria-5)

The code system options for [Criteria which would indicate whether an event is a yellow card incident](../code-systems/#criteria-which-would-indicate-whether-an-event-is-a-yellow-card-incident) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Side effects (also known as Adverse Drug Reactions or ADRs) |
| `  2` | Defective or counterfeit medicines |
| `  3` | Defective or counterfeit medical devices |
| `  4` | Poor packaging or design of medicines that might lead to errors |
| `  5` | Poor packaging or design of medical devices that might lead to errors |
| `  6` | None of the above |
| `  7` | I don't know |

### DrugReactionOther

 Definition: Other indication of drug reaction

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### DrugInvolvementFactors

 Definition: How drugs were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/drugs-involved-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/drugs-involved-5)

The code system options for [Drugs involved](../code-systems/#drugs-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too much medication was prescribed/dispensed/administered |
| `  2` | Too little medication was prescribed/dispensed/administered |
| `  3` | The medication was prescribed/dispensed/administered incorrectly |
| `  4` | Something was wrong with the medication and/or it's packaging |
| `  5` | Other |
| `  6` | I don't know |

### DrugUsedTooMuch

 Definition: How too much of a drug was used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-drug-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-drug-5)

The code system options for [Too much drug](../code-systems/#too-much-drug) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The prescribed/dispensed/administered dosage was too high |
| `  2` | The medication was prescribed/dispensed/administered too early |
| `  3` | The medication was prescribed/dispensed/administered for too long a duration |
| `  4` | The medication was prescribed/dispensed/administered at too fast a rate |
| `  5` | The medication was prescribed/dispensed/administered too frequently |
| `  6` | The medication was prescribed/dispensed/administered when it should not have been |

### DrugInsufficientDetails

 Definition: How too little of a drug was used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-drug-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-little-drug-5)

The code system options for [Too little drug](../code-systems/#too-little-drug) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The prescribed/dispensed/administered dosage was too low |
| `  2` | The medication was prescribed/dispensed/administered too late |
| `  3` | The medication was prescribed/dispensed/administered for too short a duration |
| `  4` | The medication was prescribed/dispensed/administered at too slow a rate |
| `  5` | The medication was not prescribed/dispensed/administered frequently enough |
| `  6` | The prescribed/dispensed/administered medication was omitted |

### ProblemDescriptionDrugs

 Definition: A description of the problem involving drugs

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### InvolvedProcesses

 Definition: Processes involved in what went wrong

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/involved-processes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/involved-processes-5)

The code system options for [Processes involved in what went wrong](../code-systems/#processes-involved-in-what-went-wrong) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/medication-administered-incorrectly-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/medication-administered-incorrectly-5)

The code system options for [The reasons for medication not being prescribed or given in the right way](../code-systems/#the-reasons-for-medication-not-being-prescribed-or-given-in-the-right-way) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/problem-medication-or-packaging-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/problem-medication-or-packaging-5)

The code system options for [What was the problem with medication or its packaging](../code-systems/#what-was-the-problem-with-medication-or-its-packaging) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The medication had been stored incorrectly/was unfit for use |
| `  2` | The medication was out of date |
| `  3` | The medication did not have the appropriate patient information leaflet |

- Type: `[x]`

## AdverseEventProblemPeople

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-people-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-people-5) `Extension`

Desc: Information about problems with people involved

- Id: adverse-event-problem-people-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-people-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-people-5)

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-involvement-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-involvement-5)

The code system options for [People Involvement](../code-systems/#people-involvement) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-actions-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-actions-5)

The code system options for [People Actions](../code-systems/#people-actions) are: 

 | Code | Display |
 | --- | --- |
| `  1` | People did too much of something |
| `  2` | People did too little of something |
| `  3` | People did one thing when they meant to do another |
| `  4` | People did not do something they should have |
| `  5` | Other |
| `  6` | I don't know |

### PeopleActionTooMuch

 Definition: How people took too much of an action

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-action-too-much-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-action-too-much-5)

The code system options for [People action too much](../code-systems/#people-action-too-much) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Something was done too many times/too frequently |
| `  2` | Something was done too quickly |
| `  3` | Something was done for too long |
| `  4` | Something was done too early/soon |
| `  5` | Something was done with too much force |

### PeopleUnavailableDetails

 Definition: How people were not available who should have been

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-unavailable-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-unavailable-5)

The code system options for [People unavailable](../code-systems/#people-unavailable) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-not-enough-action-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-not-enough-action-5)

The code system options for [People not enough action](../code-systems/#people-not-enough-action) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Something was done too few times/not frequently enough |
| `  2` | Something was done too slowly |
| `  3` | Something was done too late |
| `  4` | Something was stopped too early |
| `  5` | Something was done with insufficient force |

### PeopleWrongActionDetails

 Definition: How people took the wrong actions

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-wrong-action-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-wrong-action-5)

The code system options for [People wrong action](../code-systems/#people-wrong-action) are: 

 | Code | Display |
 | --- | --- |
| `  1` | One action was taken in place of another |
| `  2` | A wrong action was taken as well as the right one |
| `  3` | The right action was only partially completed |

### PeopleOmittedActionDetails

 Definition: How people did not do something that was needed

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-did-not-do-something-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/people-did-not-do-something-5)

The code system options for [People did not do something](../code-systems/#people-did-not-do-something) are: 

 | Code | Display |
 | --- | --- |
| `  1` | People did not know the right thing to do |
| `  2` | People knew what to do but it did not happen |

### ProblemDescriptionActions

 Definition: A description of the problem involving people's actions

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventProblemDevices

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-devices-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-devices-5) `Extension`

Desc: Information about problems with devices involved

- Id: adverse-event-problem-devices-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-devices-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-devices-5)

### DeviceInvolvementFactors

 Definition: How devices were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/devices-involved-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/devices-involved-5)

The code system options for [Devices involved](../code-systems/#devices-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The device was used when it should not have been |
| `  2` | The device was not used when it should have been |
| `  3` | The device was used incorrectly |
| `  4` | The device was available but broken, not fit for use or didn't perform as expected |
| `  5` | The device was involved in an accident, trip or collision |
| `  6` | Other |
| `  7` | I don't know |

### DeviceUsedUnnecessarily

 Definition: How a device was used unnecessarily

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-used-unnecessarily-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-used-unnecessarily-5)

The code system options for [Device used unnecessarily](../code-systems/#device-used-unnecessarily) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too many devices were used/The device was not required |
| `  2` | The device was used too soon |
| `  3` | The device was used for too long |
| `  4` | The device was accidentally retained |
| `  5` | The device was overused or used on too high a setting |

### DeviceInsufficientDetails

 Definition: How the use of devices was insufficient

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/devices-insufficient-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/devices-insufficient-5)

The code system options for [Devices insufficient](../code-systems/#devices-insufficient) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too few devices were used |
| `  2` | There was a delay in using the device |
| `  3` | The devices was not used for long enough |
| `  4` | The device was not available |
| `  5` | The device was underused or used on too low a setting |

### DeviceWrongUsageDetails

 Definition: How a device was used incorrectly

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-used-wrongly-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-used-wrongly-5)

The code system options for [Device used wrongly](../code-systems/#device-used-wrongly) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong device was used instead of the correct device |
| `  2` | The wrong device was used alongside the correct device |
| `  3` | Only part of the correct device was used |
| `  4` | The device was used off-license or for an unintended purpose |
| `  5` | The device was not used as per instructions for use or was set up incorrectly |

### DeviceBrokenDetails

 Definition: How a device was broken

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-broken-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-broken-5)

The code system options for [Indication of how a device was broken](../code-systems/#indication-of-how-a-device-was-broken) are: 

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

### ProblemDescriptionDevices

 Definition: A description of the problem involving devices

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

## AdverseEventProblemTissuesOrgans

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-tissues-organs-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-tissues-organs-5) `Extension`

Desc: Information about problems with tissues or organs for transplant involved

- Id: adverse-event-problem-tissues-organs-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-tissues-organs-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-tissues-organs-5)

### TissueOrgansInvolvementFactors

 Definition: How tissue and organs for transplant were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/tissue-and-organs-for-transplant-involved-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/tissue-and-organs-for-transplant-involved-5)

The code system options for [Tissue and organs for transplant involved](../code-systems/#tissue-and-organs-for-transplant-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too much/many tissues or organs for transplant were used |
| `  2` | Too few/little tissues or organs for transplant were used |
| `  3` | The wrong tissues or organs for transplant were used |
| `  4` | Tissues or organs for transplant were not used when they should have been |
| `  5` | Tissues or organs for transplant were available but damaged or unfit for use |
| `  6` | Other |
| `  7` | I don't know |

### TissueOrgansUsedTooMuch

 Definition: How too much tissue and organs for transplant were used

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-tissue-and-organs-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/too-much-tissue-and-organs-5)

The code system options for [Too much tissue and organs](../code-systems/#too-much-tissue-and-organs) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too great a quantity or number of tissues or organs for transplant were used |
| `  2` | Tissues or organs for transplant were used when they were not required |
| `  3` | Tissues or organs for transplant were used too soon |

### TissueOrgansInsufficientDetails

 Definition: How insufficient tissue or organs for transplant were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/way-insufficient-tissues-or-organs-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/way-insufficient-tissues-or-organs-5)

The code system options for [Way insufficient tissues or organs](../code-systems/#way-insufficient-tissues-or-organs) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Too little a quantity or number of tissues or organs for transplant were used |
| `  2` | There was a delay in using tissues or organs for transplant |

### TissueOrgansWrongDetails

 Definition: How the wrong tissues or organs for transplant were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incorrect-tissues-or-organs-for-transplant-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incorrect-tissues-or-organs-for-transplant-5)

The code system options for [Incorrect tissues or organs for transplant](../code-systems/#incorrect-tissues-or-organs-for-transplant) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong tissues or organs for transplant were used instead of the correct ones |
| `  2` | The wrong tissues or organs for transplant were used alongside the correct ones |
| `  3` | Only part of the correct tissues or organs for transplant were used |
| `  4` | Tissues or organs for transplant were used for an unintended purpose |
| `  5` | Tissues or organs for transplant were not used as per instructions for use |

### TissuesOrgansDamagedDetails

 Definition: How damaged tissue or organs for transplant were involved

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/damaged-tissues-or-organs-from-transplant-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/damaged-tissues-or-organs-from-transplant-5)

The code system options for [Damaged tissues or organs from transplant](../code-systems/#damaged-tissues-or-organs-from-transplant) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The packaging/label was damaged/unclear making them unfit for use |
| `  2` | The tissues or organs for transplant were contaminated |
| `  3` | The tissues or organs for transplant had not been not stored correctly |
| `  4` | The tissues or organs for transplant were damaged or of unusable quality |
| `  5` | The tissues or organs for transplant were used as per guidance but did not perform as expected |
| `  6` | There were no consumables available that were required to transplant tissues or organs |

### ProblemDescriptionTissuesOrgans

 Definition: A description of the problem involving tissue and organs for transplant

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

### TissueOrgansNotUsed

 Definition: Reasons for tissues or organs not being used when they should have been

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/tissue-organs-not-used-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/tissue-organs-not-used-5)

The code system options for [Reasons for tissue or organs not being used when they should have been](../code-systems/#reasons-for-tissue-or-organs-not-being-used-when-they-should-have-been) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The required tissues or organs for transplant were not available |
| `  2` | The need for tissues or organs for transplant was not identified |

- Type: `[x]`

## AdverseEventProblemITSystems

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-it-systems-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-it-systems-5) `Extension`

Desc: Information about problems with IT systems or software involved

- Id: adverse-event-problem-it-systems-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-it-systems-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-problem-it-systems-5)

### ITSystemsInvolvementFactors

 Definition: How IT systems and software were involved in an unexpected way

- Cardinality

    - Min: 0

    - Max: 10

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/it-systems-and-software-involved-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/it-systems-and-software-involved-5)

The code system options for [IT systems and software involved](../code-systems/#it-systems-and-software-involved) are: 

 | Code | Display |
 | --- | --- |
| `  1` | The wrong IT system or software was used |
| `  2` | IT systems or software were used in a way they were not designed to be |
| `  3` | IT systems or software were not used when they should have been |
| `  4` | IT systems or software were faulty/malfunctioned |
| `  5` | IT systems or software was not fit for purpose/did not perform adequately |
| `  6` | Other |
| `  7` | I don't know |

### ProblemDescriptionSystemsSoftware

 Definition: A description of the problem involving IT systems and software

- Cardinality

    - Min: 0

    - Max: 1

- Type: `String`

- Type: `[x]`

Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-patient-5]()
Reference

Desc: A profile for the patient subject used by the NHS Improvement Patient Safety Incident Management System

- Id: adverse-event-patient-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-patient-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-patient-5)

### PatientInformation

- Cardinality

    - Min: 0

    - Max: 100

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-information-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-information-5) `Extension`

Desc: A collection of patient details relevant to adverse events

- Id: patient-information-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-information-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/patient-information-5)

#### PhysicalHarm

 Definition: Level of physical harm sustained by the patient

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/level-of-physical-harm-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/level-of-physical-harm-5)

The code system options for [Level of Physical Harm](../code-systems/#level-of-physical-harm) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/level-of-psychological-harm-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/level-of-psychological-harm-5)

The code system options for [Level of Psychological Harm](../code-systems/#level-of-psychological-harm) are: 

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

#### AgeAtTimeOfIncidentDays

 Definition: The patient's age at the time of the incident

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Integer`

#### AgeBracket

 Definition: The patient's estimated age when the exact age is unknown

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/age-brackets-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/age-brackets-5)

The code system options for [Age Brackets](../code-systems/#age-brackets) are: 

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

    For full list go to [age-brackets-5](../code-systems/age-brackets)




#### Gender

 Definition: The gender of the patient

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/gender-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/gender-5)

The code system options for [The gender of a person used for administrative purposes](../code-systems/#the-gender-of-a-person-used-for-administrative-purposes) are: 

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

#### PatientEthnicity

 Definition: The self identified ethnicity of the patient

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ethnicity-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ethnicity-5)

The code system options for [Ethnicity](../code-systems/#ethnicity) are: 

 | Code | Display |
 | --- | --- |
| ` 11` | English, Welsh, Scottish, Northern Irish or British |
| ` 12` | Irish |
| ` 13` | Any other White background |
| ` 21` | White and Black Caribbean |
| ` 22` | White and Black African |
| ` 23` | White and Asian |
| ` 24` | Any other mixed or multiple ethnic background |
| ` 31` | Indian |
| ` 32` | Pakistani |
| ` 33` | Bangladeshi |
| ... | ... |

!!! info "Displaying 10 of 17"

    For full list go to [ethnicity-5](../code-systems/ethnicity)




#### StrengthOfAssociation

 Definition: Extent to which the problem was associated with the patient outcome

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/strength-of-association-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/strength-of-association-5)

The code system options for [Strength of Association](../code-systems/#strength-of-association) are: 

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



Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-location-5]()
Reference

Desc: A profile describing the location where an AdverseEvent has taken place

- Id: adverse-event-location-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-location-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-location-5)

### LocationDetails

- Cardinality

    - Min: 1

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/location-details-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/location-details-5) `Extension`

Desc: Further details about an adverse event location

- Id: location-details-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/location-details-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/location-details-5)

#### LocationKnown

 Definition: The location where there event took place

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5)

The code system options for [Yes-No-Unknown Codes](../code-systems/#yes-no-unknown-codes) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-5)

The code system options for [ODS Codes](../code-systems/#ods-codes) are: 

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

    For full list go to [ods-codes-5](../code-systems/ods-codes)




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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/service-type-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/service-type-5)

The code system options for [Service Type](../code-systems/#service-type) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Acute, general or specialist services (including inpatient, ED, outpatient and 'outsourced hospital care') |
| ` 19` | Maternity services (inpatient or community) |
| ` 17` | GP including out-of-hours services and minor injury units |
| ` 18` | NHS 111 |
| `  3` | Ambulance and 999 |
| `  4` | Mental health services (inpatient or community) |
| `  6` | Community therapy services |
| `  7` | Community general/district nursing |
| `  8` | Prison healthcare |
| `  9` | Community pharmacy |
| ... | ... |

!!! info "Displaying 10 of 17"

    For full list go to [service-type-5](../code-systems/service-type)




#### LocationWithinService

 Definition: The location within the service where an adverse event occurred

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incident-location-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/incident-location-5)

The code system options for [Incident Location](../code-systems/#incident-location) are: 

 | Code | Display |
 | --- | --- |
| `  1` | Public place |
| `  2` | Private home |
| `  3` | Care home |
| `  4` | Hospital |
| ` 10` | Mental health unit |
| ` 11` | General practice building |
| ` 12` | Community pharmacy |
| `  5` | Another sort of healthcare building |
| `  6` | Ambulance or other healthcare vehicle |
| `  7` | Prison |
| ... | ... |

!!! info "Displaying 10 of 12"

    For full list go to [incident-location-5](../code-systems/incident-location)




#### ResponsibleSpecialty

 Definition: Specialty caring for the patient at the time the problem occurred

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/specialty-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/specialty-5)

The code system options for [Specialty](../code-systems/#specialty) are: 

 | Code | Display |
 | --- | --- |
| `  2` | Acute internal medicine |
| `109` | Addiction |
| `110` | Adult Cystic Fibrosis |
| `  3` | Adult Mental Health |
| `102` | Allergy |
| `  4` | Allied Health Professional |
| `  5` | Anaesthetics |
| `111` | Anticoagulants |
| `112` | Art Therapy |
| `103` | Audio Vestibular Medicine |
| ... | ... |

!!! info "Displaying 10 of 202"

    For full list go to [specialty-5](../code-systems/specialty)




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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-5)

The code system options for [ODS Codes](../code-systems/#ods-codes) are: 

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

    For full list go to [ods-codes-5](../code-systems/ods-codes)




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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-location-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/risk-location-5)

The code system options for [Risk location](../code-systems/#risk-location) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/location-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/location-5)

The code system options for [Location](../code-systems/#location) are: 

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



Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-practitioner-5]()
Reference

Desc: A profile for the practitioner who records an AdverseEvent as used by the NHS Improvement Patient Safety Incident Management System

- Id: adverse-event-practitioner-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-practitioner-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-practitioner-5)

### PractitionerDetails

- Cardinality

    - Min: 1

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/practitioner-details-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/practitioner-details-5) `Extension`

Desc: Information about the practitioner that reported an adverse event

- Id: practitioner-details-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/practitioner-details-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/practitioner-details-5)

#### ReporterType

 Definition: Who the reporter of an adverse event is

- Cardinality

    - Min: 0

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-type-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-type-5)

The code system options for [Reporter Type](../code-systems/#reporter-type) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/staff-type-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/staff-type-5)

The code system options for [Staff type](../code-systems/#staff-type) are: 

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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-relationship-to-event-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/reporter-relationship-to-event-5)

The code system options for [Reporter relationship to event](../code-systems/#reporter-relationship-to-event) are: 

 | Code | Display |
 | --- | --- |
| `  1` | I witnessed it but was not directly involved in the patient's care |
| `  2` | I was told about it |
| `  3` | I found it in a case record review or audit |
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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/ods-codes-5)

The code system options for [ODS Codes](../code-systems/#ods-codes) are: 

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

    For full list go to [ods-codes-5](../code-systems/ods-codes)




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

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/anonymity-reasons-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/anonymity-reasons-5)

The code system options for [Reasons for recording the event anonymously](../code-systems/#reasons-for-recording-the-event-anonymously) are: 

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



Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-medication-5]()
Reference

Desc: This resource is primarily used for the identification and definition of a medication. It covers the ingredients and the packaging for a medication.

- Id: adverse-event-medication-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-medication-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-medication-5)

### MedicationAdministration

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/medication-administration-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/medication-administration-5) `Extension`

Desc: Information on the delivery of a medication

- Id: medication-administration-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/medication-administration-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/medication-administration-5)

#### MedicationAdministration

 Definition: Was a the medication administered by using a device

- Cardinality

    - Min: 1

    - Max: 1

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/yes-no-unknown-codes-5)

The code system options for [Yes-No-Unknown Codes](../code-systems/#yes-no-unknown-codes) are: 

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



Target profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-5]()
Reference

Desc: This resource identifies an instance or a type of a manufactured item that is used in the provision of healthcare without being substantially changed through that activity. The device may be a medical or non-medical device. Medical devices include durable (reusable) medical equipment, implantable devices, as well as disposable equipment used for diagnostic, treatment, and research for healthcare and public health. Non-medical devices may include items such as a machine, cellphone, computer, application, etc.

- Id: adverse-event-device-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-5)

### AdverseEventDeviceDetails

- Cardinality

    - Min: 0

    - Max: 1

Nested profile: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-details-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-details-5) `Extension`

Desc: Further details about a device which is related to an adverse event

- Id: adverse-event-device-details-5

- Url: [https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-details-5](https://psims-uat.azure-api.net/taxonomy/fhir/StructureDefinition/adverse-event-device-details-5)

#### DeviceType

 Definition: The type of medical device that was involved in an incident

- Cardinality

    - Min: 0

    - Max: 100

- Type: `Code`

- Value set Url: [https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-type-5](https://psims-uat.azure-api.net/taxonomy/fhir/ValueSet/device-type-5)

The code system options for [Device Type](../code-systems/#device-type) are: 

 | Code | Display |
 | --- | --- |
| `  2` | Anaesthetic and airway devices and breathing masks and tubing |
| `  3` | Anaesthetic machines |
| `  4` | Autoclaves and decontamination equipment |
| `  5` | Bath and shower aids (without integral hoists) |
| ` 97` | Baths with integral patient hoist |
| `  7` | Beds, mattresses, side rails  (excluding pressure relieving devices) |
| `  8` | Blood fridges |
| `  9` | Blood gas analysers and accessories, including blood gas syringe or needle sets |
| ` 10` | Blood pressure equipment |
| ` 36` | Breast implants |
| ... | ... |

!!! info "Displaying 10 of 93"

    For full list go to [device-type-5](../code-systems/device-type)




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



