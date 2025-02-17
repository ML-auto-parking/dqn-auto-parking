﻿using UnityEngine;

namespace AutonomousParking.Car.UserInput
{
    public class CarUserInputHandler : MonoBehaviour
    {
        [SerializeField] private CarData carData;
        private CarUserInputInterpreter interpreter;

        private void Awake() => interpreter = new CarUserInputInterpreter(carData);

        private void Update()
        {
            carData.CurrentWheelTorque = interpreter.InterpretAsWheelTorque(CarUserInputData.WheelTorque);
            carData.CurrentSteeringAngle = interpreter.InterpretAsSteeringAngle(CarUserInputData.SteeringAngle);
        }
    }
}