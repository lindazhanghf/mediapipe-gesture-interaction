# Hand Tracking

Based on [MediaPipe HandPose](https://github.com/tensorflow/tfjs-models/tree/master/handpose) demo from TensorFlow JS.

## Usage

Start Unity game, this will start the web socket server (GameServer.cs). Then open the HTML in a web browser (verified in FireFox), this will open the web cam, download Handpose model from @tensorflow, and send data to Unity if a hand is detected.