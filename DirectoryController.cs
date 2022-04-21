getAllRealtors()
//get all the realtors in the directory

getAllDeveloper()
//get all the developers in the directory

[HTTPPOST, Route("/realtor/{query}")]
searchRealtors()
//get realtors by running a query

[HTTPGET, Route("/developer/{query}")]
searchDevelopers()
//get developers by running a query

[HTTPGET, Route("/realtor/{id}")]
getRealtorInfoByID();
//gets the realtors by their ID

[HTTPGET, Route("/developer/{id}")]
getDeveloperInfoByID();
//gets the developers by their ID

