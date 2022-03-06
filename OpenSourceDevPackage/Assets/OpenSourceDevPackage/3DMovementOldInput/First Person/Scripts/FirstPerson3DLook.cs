// License
/*
 MIT License

Copyright (c) 2022 EmberFoxStudios

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software. Must also include a link to the project github repo https://github.com/emberfoxstudios/OpenSourceUnityDevPackage

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

// Art
/*

                 _ _.-'`-._ _
                ;.'________'.;
     _________n.[____________].n_________
    |""_""_""_""||==||==||==||""_""_""_""]
    |"""""""""""||..||..||..||"""""""""""|
    |LI LI LI LI||LI||LI||LI||LI LI LI LI|
    |.. .. .. ..||..||..||..||.. .. .. ..|
    |LI LI LI LI||LI||LI||LI||LI LI LI LI|
 ,,;;,;;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;,,
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
 
 */

// Script Description
/*
Script Description: This script is part of the FirstPerson 3DMovement Module and is the script that allows a camera attached to the player to look
on the X and Y axis. This script is for the old input method.

Please add your name or chosen online name and upt to 1 link in the below list if you have worked on this script.

Contributors:

Bella Weiss @ Ember Fox Studios
Oliver Mills
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson3DLook : MonoBehaviour
{
    //Variable Start

    /// <summary>
    /// Store current X axis from input.
    /// </summary>
    private float lookX;

    /// <summary>
    /// Store current Y axis from the input.
    /// </summary>
    private float lookY;

    //Inspector Controlled Variables.

    [Tooltip("Controls how sensitive the look controls are. 100f by default.")]
    public float sensitivity = 100f;

    [Tooltip("Reference to the player object for the camera to rotate via player input.")]
    public Transform playerObject;


    void Update()
    {
        //Check X and Y Axis
        AxisCheck();

        //Apply Rotation to Player OBJ
        RotatePlayerObj();

    }



    /// <summary>
    /// Moves the position of the x and y axis when gvien input from the user
    /// Input.GetAxis: You can use arrow keys, wasd, or a controller to give a value between -1 and 1
    /// Time.deltaTime: The time between frames. Used so if there are frame drops the movement stays consistent
    /// </summary>
    void AxisCheck()
    {
        // Check X Axis
        lookX = Input.GetAxis("Horizontal") * sensitivity * Time.deltaTime;

        // Check Y Axis
        lookY = Input.GetAxis("Vertical") * sensitivity * Time.deltaTime;

    }

    /// <summary>
    /// Rotates the player based on the horizontal input
    /// </summary>
    void RotatePlayerObj()
    {
        playerObject.Rotate(Vector3.up * lookX);
    }
}



