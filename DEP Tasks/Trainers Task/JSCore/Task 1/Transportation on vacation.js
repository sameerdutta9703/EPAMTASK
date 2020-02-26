function rentalCarCost(d) {
    // Your solution here
    if(d>=7){
      return amount=(d*40)-50;
    }
    else if(d<7 && d>=3){
      return amount=(d*40)-20;
    }
    else{
      return d*40;
    }
  }