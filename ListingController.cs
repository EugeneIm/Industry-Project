[Authorize Role = "Admin, PPBuyer"]
[HTTPGET]
getMyListings()
//Gets all the listings for the current user.

[HTTPPOST]
createNewListing()
//Creates a new listing.

[HTTPDELETE]
removeMyListing()
//Removes a listing.

