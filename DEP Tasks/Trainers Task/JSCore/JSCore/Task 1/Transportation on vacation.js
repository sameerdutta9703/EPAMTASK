function rentalCarCost(days) {
    // Your solution here
    if(days>=7){
      return amount=(days*40)-50;
    }
    else if(days<7 && days>=3){
      return amount=(days*40)-20;
    }
    else{
      return days*40;
    }
  }