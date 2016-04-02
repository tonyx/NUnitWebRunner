NUnitWebRunner
==============

Note: I have not mantained this project for a while.

Web runner interface for NUnit tests. 

Why to use it: when you you havecode highly dependent of the web execution environment so you cannot easily tested outside of the container hosting the whole app. So you can just deploy a web page and run unit tests as an actual web page deployed with the whole application. 

How to use it (not tried yet): Write your tests. Run the app. Load the page that in this project is the default, then it shoud run all and visualize all the tests of your projects.

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


