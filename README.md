# SkiResortTrack
Solution contains two projects:

* the SkiResort track contains the solution to a challenge given in the resources folder.
* The UnitTestSkiTrack contains a simple unit testing using the data given as example in the challenge document, also guaranteeing that the result is the one expected.

Notes:
* The unit testing contains absolute routes that might fail when the solutions is in another computer so it must be changed when downloaded.
* At the beggining the user interface was suposed to show a progress bar but after doing the first tests with the big map I realized that the time was really short so it wouldn't be really useful
* thing that could be improved:
  * Use a backgroudworker to separte the user interface from the processing, but its needed to change the way the functions are distributed now
  * Use threading to solve the map faster (however the single thread is really fast so may not be necesary)
