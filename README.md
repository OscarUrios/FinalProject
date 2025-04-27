# FinalProject

DoYourTasks is a desktop app that will help you organice your tasks and keep track of your progress.
It's an app that is oriented to help you to be more productive.
To do that, the program will create an object for each task and will store it in a list.
You will be able to create new groups and add task to them.

At the bagining of the program, the user must enter its name. If the user is already registered, 
	the program will load the text file asigned to their name.
If the user it's not registered, the program will prompt if the user wants to create a new account.
If the user says no, the program will ask again for the name.
If the user says yes, the program will create a new file.

If the user was registered, the program will load the tasks from its file and will show their name in a listbox.
The user can click on the tasks and information like the type of task, the deadline date and the notes attached to the task will be shown.

The user will had buttons with the next functions:

	- When nothing is selected:
		- Create new tasks.
			Will open a new window with a textbox for the name of the task, a combobox to select the group,
   				a datepicker for the deadline, a multiline textbox for notes, a cancel button and a save button.
			If no group is selected, the task will be added to the default group.
		- Create new groups
			Will open a new window with a textbox for the name of the group, a cancel button and a save button.
			If the group already exists, the program will prompt the user to enter a new name.
	- When a task is selected:
		- Edit task
			Will open a new window with the data of the task already filled, a cancel button and a save button.
			The user can modify this fields and save them.
		- Mark task as done.
			Will modify a boolean value in the task object to true.
		- Move task to another group
			Will open a new window with a combobox to select the group, a cancel button and a save button.
		- Delete task
	- When a group is selected:
		- delete group
			It will move all the tasks from the selected group to the default group without name.
			The default group will be created when the program first launches.
		- modify group
			Will open another window with a textbox, a cancel button and a save button.
			In the text box you will change the name of the group.

When the program is closing, it will save the tasks in the file assigned to the user.
