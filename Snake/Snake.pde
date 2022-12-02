import java.util.Random;

snake snake1;
food food1;
bad bad1;
double distance = 0, distance1 = 0, distance2 = 0, distance3 = 0, distance4 = 0, distance5 = 0, distance6 = 0, distance7 = 0, distance8 = 0, distance9 = 0;
int score, highscore;
int direction;
int sFood = (12);
int gridscale = 20;
int cols, rows;
boolean stopgame = false;

void setup() { 
  size(800, 540); //Makes the size of the pop up.
  snake1 = new snake(); 
  food1 = new food();
  bad1 = new bad();
  score = 0;
  highscore = 0;

  cols = width/gridscale;
  rows = height/gridscale;
}
void draw() {
  if (stopgame) //If stopgame = true, makes the game not do anything, therefore its stopped.
  {
  } else { //If stopgame = false, makes the game continue working.
    frameRate(8); //Default value for the speed or frameRate of the game.
    background(0);
    for (int i = 0; i < cols; i++) //Grid, was made using a nested for loop. Learnt in CS161.
    {
      for (int j = 0; j < rows; j++) //Grid, was made using a nested for loop. Learnt in CS161.
      {
        int x = i*gridscale;
        int y = j*gridscale;
        fill(0);
        stroke(100, 100, 100);
        rect(x, y, gridscale, gridscale); //draws the squares for the grid.
      }
    }

    fill(0);
    rect(540, 0, 280, 540);
    drawScoreBoard(); //Draws the scoreboard/controls.
    snake1.move(); //Initiates the snakes movement from class snake.
    snake1.display(); //Displays the snake from class snake.
    food1.display(); //Displays the green apples from the class food.
    bad1.display(); //Displays the brown apple from the class bad.

    if ( dist(food1.numx, food1.numy, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen) { //if the distance between food values and current position of the snake is less than the size of the snake.
      food1.reset();                                                                            //Reset the food.
      snake1.addLink();                                                                         //Adds a link to the snake.
    }
    if ( dist(bad1.numbx, bad1.numby, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen || dist(bad1.numbx1, bad1.numby1, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen || dist(bad1.numbx2, bad1.numby2, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen
      || dist(bad1.numbx3, bad1.numby3, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen || dist(bad1.numbx4, bad1.numby4, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen || dist(bad1.numbx5, bad1.numby5, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen
      || dist(bad1.numbx6, bad1.numby6, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen || dist(bad1.numbx7, bad1.numby7, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen || dist(bad1.numbx8, bad1.numby8, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen
      || dist(bad1.numbx9, bad1.numby9, snake1.xval.get(0), snake1.yval.get(0)) < snake1.sidelen) { //Same as the top version, except there are many bad food values.
      snake1.removeLink();                                                                       //Removes 1 link of the snake.
      bad1.reset();                                                                              //Resets the brown apple.
      food1.reset();                                                                             //Resets the green apple. This was done in order to fix a bug. See below.
    }
         distance =  Math.sqrt(Math.pow((food1.numx-bad1.numbx1), 2) + Math.pow((food1.numy-bad1.numby1), 2)); //Gets the distance between 2 points
         distance1 = Math.sqrt(Math.pow((food1.numx-bad1.numbx2), 2) + Math.pow((food1.numy-bad1.numby2), 2));
         distance2 = Math.sqrt(Math.pow((food1.numx-bad1.numbx3), 2) + Math.pow((food1.numy-bad1.numby3), 2));
         distance3 = Math.sqrt(Math.pow((food1.numx-bad1.numbx4), 2) + Math.pow((food1.numy-bad1.numby4), 2));
         distance4 = Math.sqrt(Math.pow((food1.numx-bad1.numbx5), 2) + Math.pow((food1.numy-bad1.numby5), 2));
         distance5 = Math.sqrt(Math.pow((food1.numx-bad1.numbx6), 2) + Math.pow((food1.numy-bad1.numby6), 2));
         distance6 = Math.sqrt(Math.pow((food1.numx-bad1.numbx7), 2) + Math.pow((food1.numy-bad1.numby7), 2));
         distance7 = Math.sqrt(Math.pow((food1.numx-bad1.numbx8), 2) + Math.pow((food1.numy-bad1.numby8), 2));
         distance8 = Math.sqrt(Math.pow((food1.numx-bad1.numbx9), 2) + Math.pow((food1.numy-bad1.numby9), 2));
         distance9 = Math.sqrt(Math.pow((food1.numx-bad1.numbx), 2) + Math.pow((food1.numy-bad1.numby), 2));
         
         if((distance) < 10 || (distance1) < 10 || (distance2) < 10 || (distance3) < 10 || (distance4) < 10 || (distance5) < 10 || (distance6) < 10 || (distance7) < 10 || (distance8) < 10 || (distance9) < 10)
         {
           food1.reset(); //If the distance between 2 any points is less than 10. Reset the red food. This is reset red food if its in the brown food.
         }
    }                

    if (snake1.len > score) { //If the length of the snake is greater than the score. Score is equal to the length of the snake.
      score = snake1.len;
    }
    if (snake1.len >= 10) { //If the length of the snake is greater than or equal to 10, increase the framerate to (10) from the default value of (8).
      frameRate(10);
    }
    if (snake1.len >= 20) { //If the length of the snake is greater than or equal to 20, increase the framerate to (12) from the previous value of (10).
      frameRate(12);
    }
    if (snake1.len >= 30) { //If the length of the snake is greater than or equal to 30, increase the framerate to (14) from the previous value of (12).
      frameRate(14);
    }
    if (snake1.len >= 40) { //If the length of the snake is greater than or equal to 30, increase the framerate to (16) from the previous value of (14).
      frameRate(16);
    }
    if (snake1.len >= 50) { //If the length of the snake is greater than or equal to 40, increase the framerate to (18) from the previous value of (16).
      frameRate(18);
    }

    if ( snake1.checkHit() == true) { //Checks void CheckHit() in class snake and stops the game if snake eats itself using a boolean statement.
      textSize(48);
      fill(255, 0, 0);
      text("GAME OVER", 150, 100);
      text("Press SPACE To Restart", 50, 150);
      delay(100);
      stopgame = true;
    }
    if (snake1.len <= 0) { //Checks if the length of the snake is less than or equal to 0, if its 0, game cannot display the snake as length cannot be 0. Therefore the game stops using the same method as above.
      textSize(48);
      fill(255, 0, 0);
      text("GAME OVER", 150, 100);
      text("Press SPACE To Restart", 50, 150);
      delay(50);
      stopgame = true;
    }
  }
void keyPressed() { 
  if (keyCode == LEFT || key == 'a' || key == 'A') { //Direction Left.  Checks if keyCode is equal to Left arrow key (Learnt this is a CS171 Lab) or if the character 'a' is pressed. See line 281 for direction.
    direction = 1;
  }
  if (keyCode == RIGHT || key == 'd' || key == 'D') { //Direction Right. Checks if keyCode is equal to Right arrow key (Learnt this is a CS171 Lab) or if the character 'd' is pressed. See line 281 for direction.
    direction = 3;
  }
  if (keyCode == UP || key == 'w' || key == 'W') { //Direction Up. Checks if keyCode is equal to Up arrow key (Learnt this is a CS171 Lab) or if the character 'w' is pressed. See line 281 for direction.
    direction = 0;
  }
  if (keyCode == DOWN || key == 's' || key == 'S') { //Direction Down. Checks if keyCode is equal to Down arrow key (Learnt this is a CS171 Lab) or if the character 's' is pressed. See line 281 for direction.
    direction = 2;
  }
  if (keyPressed&&key==' ') { //Checks if there is a keyPressed and if that key is the SpaceBar then executes the code below.
    background(0); //resets the background to black.
    food1.reset(); //resets the green apple
    bad1.reset();  //resets the brown apple.
    stopgame = false; //resets game logic.
    score = 10; //resets score to 10.
    snake1.len = 1; //resets snake length to 1.
    snake1.xval.set(0, 2); //spawns the snake at x = 2.
    snake1.yval.set(0, 1); //spawns the snake at y = 2.
    direction = 3; //While spawning snake, the direction of movement is set to Right. See line 281.
  }
}
void drawScoreBoard() { //Draws the scoreboard/Everything that has text, code is self explanatory.
  fill(255, 0, 0);
  text("Score: "+snake1.len*10, 580, 100);
  text("Length: "+snake1.len, 580, 120);
  textSize(24);
  text("RULES!", 560, 200); 
  text("____________________", 550, 205); 
  fill(255);
  textSize(11);
  text("Get as big as possible.", 550, 220); 
  text("If you eat yourself, the game is over.", 550, 240); 
  text("If you eat a brown apple, you lose 10 points", 550, 260); 
  text("Pace of the game increases the more points\n you have \n                    GOOD LUCK!", 550, 280); 
  textSize(9);
  fill(0, 255, 0);
  text("P.S If red apple disappears \npress SPACE or eat a brown apple", 650, 10); 

  fill(255, 0, 0);
  textSize(24);
  text("Controls", 560, 380); 
  text("____________________", 550, 385); 
  textSize(16);
  fill(255);
  text("MOVE UP: W / Up Arrowkey", 550, 410); 
  text("MOVE DOWN: S / Down Arrowkey", 550, 435);
  text("MOVE LEFT: A / Left Arrowkey", 550, 460);
  text("MOVE RIGHT: D / Right Arrowkey", 550, 485);
  text("RESTART: SPACE", 550, 510);
}
class food { //Makes a class called food. I made this class in order to have variables and fuctions in one place rather than the whole sketch.
  int numx, numy;
  food() {
    int arrnumx[] ={24, 44, 64, 84, 104, 124, 144, 164, 184, 204, 224, 244, 264, 284, 304, 324, 344, 364, 384, 404, 424, 444, 464, 484, 504, 524}; //Makes an array for the x value and stores elements as shown below.
    numx = arrnumx[new Random().nextInt(arrnumx.length)]; //Takes a random number from the length of the array, and stores it in a new variable.
    println("X " +numx); //Printing value of the random number to test.

    int arrnumy[] ={24, 44, 64, 84, 104, 124, 144, 164, 184, 204, 224, 244, 264, 284, 304, 324, 344, 364, 384, 404, 424, 444, 464, 484, 504, 524}; //Same as above just for the value y.
    numy = arrnumy[new Random().nextInt(arrnumy.length)];
    println("y " +numy);
  }
  void display() { //Displays the green apple.
    fill(255, 0, 0);
    rect(numx, numy, sFood, sFood); //sFood declared above void setup();
  }
  void reset() { //Function to reset the green apple. Same code as in food()

    int arrnumx[] ={24, 44, 64, 84, 104, 124, 144, 164, 184, 204, 224, 244, 264, 284, 304, 324, 344, 364, 384, 404, 424, 444, 464, 484, 504, 524};
    numx = arrnumx[new Random().nextInt(arrnumx.length)];
    println("X " +numx +"\t");

    int arrnumy[] ={24, 44, 64, 84, 104, 124, 144, 164, 184, 204, 224, 244, 264, 284, 304, 324, 344, 364, 384, 404, 424, 444, 464, 484, 504, 524};
    numy = arrnumy[new Random().nextInt(arrnumy.length)];
    println("y " +numy +"\t");
  }
}
class bad { //Makes a class called bad. I made this class for the same reason I made the class above.
  int numbx, numby;
  int numbx1, numby1, numbx2, numby2, numbx3, numby3, numbx4, numby4, numbx5, numby5, numbx6, numby6, numbx7, numby7, numbx8, numby8, numbx9, numby9; //A lot of variables, as I wanted to have many obstacles in my game (To make it different).
  bad() { 
    int arrnumbx[] ={44, 64, 84, 104, 124, 144, 164, 184, 204, 224, 244, 264, 284, 304, 324, 344, 364, 384, 404, 424, 444, 464, 484, 504, 524}; //Same code as in class food(), except there is a lot more variables.
    numbx = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx1 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx2 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx3 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx4 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx5 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx6 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx7 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx8 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx9 = arrnumbx[new Random().nextInt(arrnumbx.length)];

    int arrnumby[] ={44, 64, 84, 104, 124, 144, 164, 184, 204, 224, 244, 264, 284, 304, 324, 344, 364, 384, 404, 424, 444, 464, 484, 504, 524}; //Same code as in class food(), except there is a lot more variables.
    numby = arrnumby[new Random().nextInt(arrnumby.length)];
    numby1 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby2 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby3 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby4 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby5 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby6 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby7 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby8 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby9 = arrnumby[new Random().nextInt(arrnumby.length)];
  }

  void display() { //Same code as in class food(), except there is a lot more variables.
    fill(124, 74, 0);
    rect(numbx, numby, sFood, sFood);
    rect(numbx1, numby1, sFood, sFood);
    rect(numbx2, numby2, sFood, sFood);
    rect(numbx3, numby3, sFood, sFood);
    rect(numbx4, numby4, sFood, sFood);
    rect(numbx5, numby5, sFood, sFood);
    rect(numbx6, numby6, sFood, sFood);
    rect(numbx7, numby7, sFood, sFood);
    rect(numbx8, numby8, sFood, sFood);
    rect(numbx9, numby9, sFood, sFood);
  }
  void reset() { //Same code as in class food(), except there is a lot more variables.
    int arrnumbx[] ={24, 44, 64, 84, 104, 124, 144, 164, 184, 204, 224, 244, 264, 284, 304, 324, 344, 364, 384, 404, 424, 444, 464, 484, 504, 524};
    numbx = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx1 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx2 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx3 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx4 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx5 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx6 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx7 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx8 = arrnumbx[new Random().nextInt(arrnumbx.length)];
    numbx9 = arrnumbx[new Random().nextInt(arrnumbx.length)];

    int arrnumby[] ={44, 64, 84, 104, 124, 144, 164, 184, 204, 224, 244, 264, 284, 304, 324, 344, 364, 384, 404, 424, 444, 464, 484, 504, 524};
    numby = arrnumby[new Random().nextInt(arrnumby.length)];
    numby1 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby2 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby3 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby4 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby5 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby6 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby7 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby8 = arrnumby[new Random().nextInt(arrnumby.length)];
    numby9 = arrnumby[new Random().nextInt(arrnumby.length)];
  }
}

class snake { //Makes a class called snake. I made this class in order to have variables and fuctions in one place rather than the whole sketch.
  int len;
  int sidelen;
  ArrayList <Integer> xval, yval; //makes xval and yval into an ArrayList.
  snake() {
    len = 1; //Length of the snake in the starting position.
    sidelen = 15; //Size of the snake in the starting position (The overall size of the square of the snake)
    direction = 3; //Direction of movement when spawning in the snake (3 = Right). See line 281 for direction.
    xval = new ArrayList(); 
    yval = new ArrayList();
    xval.add(2); // spawns the snake at x = 2
    yval.add(1); // spawns the snake at y = 2
  }
  void move() {
    for (int i = len - 1; i > 0; i = i - 1) { //for loop
      xval.set(i, xval.get(i - 1));
      yval.set(i, yval.get(i - 1));
    }
    switch(direction) { //Movement of the snake.
    case 0: 
      yval.set(0, yval.get(0) - gridscale); 
      break; //UP. Decreases the y value by the size of the grid which is 20 pixels.
    case 1: 
      xval.set(0, xval.get(0) - gridscale); 
      break; //LEFT. Decreases the x value by the size of the grid which is 20 pixels.
    case 2: 
      yval.set(0, yval.get(0) + gridscale); 
      break; //DOWN. Increases the y value by the size of the grid which is 20 pixels.
    case 3: 
      xval.set(0, xval.get(0) + gridscale); 
      break; //RIGHT. Increases the x value by the size of the grid which is 20 pixels.
    }
    xval.set(0, (xval.get(0) + 540) % 540); //This is for the borders. Sets the value for xval if the snake goes outside the the limit of size(). Restricted into a box in my case.
    yval.set(0, (yval.get(0) + 540) % 540); //This is for the borders. Sets the value for yval if the snake goes outside the the limit of size(). Restricted into a box in my case.
  }
  void display() { //Displays the snake
    for (int i = 0; i <len; i++) {
      stroke(0);
      fill(0, 255, 0);
      rect(xval.get(i), yval.get(i), sidelen, sidelen);
    }
  }
  void addLink() { //Adds snake length
    xval.add(sidelen);
    yval.add(sidelen);
    len++;
  }
  void removeLink() { //Removes a link of the snake.
    xval.add(sidelen);
    yval.add(sidelen);
    len--;
  }

  boolean checkHit() { //checks if snake is eating itself.
    for (int i = 1; i < len; i++) {
      if ( dist(xval.get(0), yval.get(0), xval.get(i), yval.get(i)) < sidelen) {
        return true;
      }
    } 
    return false;
  }
}
