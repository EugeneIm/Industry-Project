[Authorize]
    {
        [HTTPGET, Route("/developer/{id}")]
        getReviewByDeveloperID()
        //get the reviews of the developers by the ID

        [HTTPGET, Route("/realtor/{id}")]
        getReviewByRealtorID()
        //get the reviews of the realtors by the ID

        //Above is available to everyone logged in or not. 
    }
[Authorize Role = "Admin, PPBuyer"]
    {
        [HTTPPOST, Route("/developer/{id}")]
        addReviewByDeveloperID()
        //add a review to the developer by the ID

        [HTTPPOST, Route("/realtor/{id}")]
        addReviewByRealtorID()
        //add a review to the realtor by the ID


        [HTTPDELETE, Route("/developer/{id}")]
        removeDeveloperReviewByID()
        //remove the developer review by the ID

        [HTTPDELETE, Route("/realtor/{id}")]
        removeRealtorReviewByID()
        //remove the realtor review by the ID

    }