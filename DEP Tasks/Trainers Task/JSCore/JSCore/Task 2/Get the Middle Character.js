function getMiddle(word)
{
  //Code goes here!
 var position;
 var length;
 
   if(word.length % 2 != 0) {
            position = word.length / 2;
            length = 1;
        } else {
            position = word.length / 2 - 1;
            length = 2;
        }

        return word.substring(position, position + length);
}