# How to obtain the appointment or time interval selected by an end-user

This code example shows how to work with selected appointments, resources and time intervals in code.

The [SchedulerControl,SelectedAppointments](http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControl_SelectedAppointmentstopic) property is bound to a data template to display the selected appointment's Subject property value.

The [SchedulerControl.DependencyPropertyChanged](http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControlBase_DependencyPropertyChangedtopic) event is handled to display the [SchedulerControl,SelectedInterval](http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControl_SelectedIntervaltopic) and [SchedulerControl,SelectedResource](http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControl_SelectedResourcetopic) property changes.
