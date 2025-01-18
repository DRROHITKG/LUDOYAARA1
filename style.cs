/* style.css */

body {
    font-family: Arial, sans-serif;
    text-align: center;
    background-color: #f3f3f3;
    margin: 0;
    padding: 0;
}

h1 {
    color: #333;
}

#game {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-top: 20px;
}

.board-container {
    display: flex;
    justify-content: center;
    margin-top: 20px;
}

#ludo-board {
    display: grid;
    grid-template-columns: repeat(15, 40px);
    grid-template-rows: repeat(15, 40px);
    border: 2px solid #333;
    width: 600px;
    height: 600px;
    background-color: white;
    position: relative;
}

.square {
    border: 1px solid #ddd;
    display: flex;
    align-items: center;
    justify-content: center;
}

.home {
    background-color: rgba(0, 0, 0, 0.1);
}

.safe-zone {
    background-color: lightgreen;
}

.token {
    width: 30px;
    height: 30px;
    border-radius: 50%;
}

.red {
    background-color: red;
}

.blue {
    background-color: blue;
}

.green {
    background-color: green;
}

.yellow {
    background-color: yellow;
}

.controls {
    margin-top: 20px;
}

button {
    background-color: #007bff;
    color: white;
    border: none;
    padding: 10px 20px;
    border-radius: 5px;
    cursor: pointer;
}

button:hover {
    background-color: #0056b3;
}

.dice-result {
    margin-top: 10px;
    font-size: 18px;
}

#players {
    margin-top: 20px;
    display: flex;
    gap: 20px;
    font-size: 18px;
}

.player {
    padding: 10px;
    border: 1px solid #333;
    border-radius: 5px;
}
