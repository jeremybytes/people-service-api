# Sample API - People.Service  

*Current Version: **.NET 9.0***

This is the code for the API used in the majority of Jeremy's code demos. It can be kept updated centrally here.  

## Projects  
Various versions of the API depending on the needs of the demo. All versions include hard-coded data and pretty-print.  

* Controller  
[./Controller/People.Service/](./Controller/People.Service/)  
A controller-based API.  

* Controller-Delay  
[./Controller-Delay/People.Service/](./Controller-Delay/People.Service/)  
A controller API that includes an artificial 3-second (all people) or 1-second (selected person) delay.  

* Minimal  
[./Minimal/People.Service/](./Minimal/People.Service/)  
A minimal API.  

* Minimal-WithDelay  
[./Minimal-Delay/People.Service/](./Minimal-Delay/People.Service/)  
A minimal API that includes an artificial 3-second (all people) or 1-second (selected person) delay.  

## Endpoints  
The port for the local-host is coded in the launchSettings.json file.  

* http://localhost:9874/people  
A full list of person objects.  

* http://localhost:9874/people/{id}  
An individual person object based on the provided {id} parameter.  

* http://localhost:9874/people/ids  
A list of the available IDs in the people data.  

___