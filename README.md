﻿# Copy Directory


Simple Windows Forms program to copy directories recursively.

## Objectives

* The copying function must reside in a separate assembly to the user interface. - Done.

* You must write the user interface as either a) Console app b) Windows Forms app c) WPF app. - Windows Forms.

* There should not be a concrete dependency between the copying assembly and the UI - i.e. you must properly separate the code. The copying assembly could be used in a web or desktop application. - Createad a class libraby and referenced it on the  main project.

* There must be a visual display of each file (including the source file path and file name) being copied during the copying process. - Done using events.

* Ideally, the UI must not “block” during the copy process. - Used Tasks to accomplish this. Had to use an Invoke because the UI can only be updated by the thread that started it.

* Users must be able to pick or specify a source and target directory. - Done with the FolderBrowserDialog.

* All files and folders (and their contents) must be copied from the source to the target. - Done.

* You must implement a recursive algorithm to copy the files. - Done.

* The application must work and not crash. - Done.