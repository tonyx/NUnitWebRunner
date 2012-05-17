NUnitWebRunner
==============

Web runner interface for NUnit tests. 

Why to use it: when you you have legacy code highly dependent of the web execution environment so cannot easily tested outside of the web environment, and you want to start writing unit tests.

how to use it (not tried yet): add the pages and the classes of this solution in your web application. Write your tests. Run the app. Load the page that in this project is the default, then it shoud run all and visualize all the tests of your projects.

code in a web application that cannot be tested from outside of your application environment.
For example: your legacy code uses some settings 

This is just a "waking skeleton". Here is a list of possible new features that I think will make the product more useful at scale.


ok features:
- pagination
- manage more icons for results states (I managed just success, ignore, and all the rest as failure)
- select unit tests to run via checkboxes
- can add test created somewhere deploying their assembly somewhere.
- select/browse by classes and namespace

wow features:
- drill down/drill up assemblies, namespaces, classes, tests
- see the sources
- interact with Ide


License: Gpl 3.


