[Authorize Role = "Admin, PPBuyer"]
[HTTPGET, Route("/ppbuyer/{id}")]
getPPBuyer()
//Takes you to the PPbuyer's profile. 

[HTTPGET, Route("/realtor/{id}")]
getRealtorInfo()
//Gets all the realtor info

[HTTPPUT, Route("/developer/{id}")]
updatePPBuyer()
//Updates the PPbuyer's profile.

[HTTPPUT, Route("/realtor/{id}")]
updateRealtorInfo()
//Updates the realtor's profile.

[HTTPPUT, Route("/developer/{id}")]
updateDeveloperInfo()
//Updates the developer's profile.

