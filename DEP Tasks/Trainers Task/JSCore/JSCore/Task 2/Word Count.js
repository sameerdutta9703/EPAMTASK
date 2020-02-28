function countWords(strSentence) {
    // // str.trim();
    // if(str.length==0){return 0;}
    // // var count=1;
    // //   for(var i=0;i<str.length;i++){
    // //     if(str.charAt(i)==" ")
    // //       count++;
    // //   }
    // //   return count;
    // str = str.replace(/(^\s*)|(\s*$)/gi,"");
    // str = str.replace(/[ ]{2,}/gi," ");
    // str = str.replace(/\n /,"\n");
    // return str.split(" ").length;
    
    //.trim() - this removes all the spaces before and after the words
    //.split() -  split it into an array upon the whitespace characters
    //\s - this is for the white space characters
    //filter - this takes a function and checks true and false and filters accordingly
    //Boolean - this is a function that checks all are true or not, here it is used to remove undefined values
     return strSentence.trim().split(/\s+/).filter(Boolean).length;
    }