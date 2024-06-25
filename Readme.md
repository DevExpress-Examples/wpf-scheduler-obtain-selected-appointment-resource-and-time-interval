<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128656057/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T564865)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXSchedulerSelection/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSchedulerSelection/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXSchedulerSelection/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXSchedulerSelection/MainWindow.xaml.vb))
<!-- default file list end -->
# How to obtain the appointment, resource or time interval selected by an end-user

This code example shows how to work with selected appointments, resources and time intervals in code.

The [SchedulerControl,SelectedAppointments](http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControl_SelectedAppointmentstopic) property is bound to a data template to display the selected appointment's Subject property value.

The [SchedulerControl.DependencyPropertyChanged](http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControlBase_DependencyPropertyChangedtopic) event is handled to display the [SchedulerControl,SelectedInterval](http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControl_SelectedIntervaltopic) and [SchedulerControl,SelectedResource](http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControl_SelectedResourcetopic) property changes.

![](https://github.com/DevExpress-Examples/how-to-obtain-the-appointment-or-time-interval-selected-by-an-end-user-t564865/blob/17.2.3%2B/images/SelectionExample.png)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-obtain-selected-appointment-resource-and-time-interval&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-obtain-selected-appointment-resource-and-time-interval&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
