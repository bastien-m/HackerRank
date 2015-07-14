//
//  main.swift
//  HackerRank
//
//  Created by Bastien on 13/07/2015.
//  Copyright (c) 2015 Bastien. All rights reserved.
//

import Foundation

//hacker rank Angry professor
let angryProfessor00 = AngryProfessor(numberOfStudent: 4, minimumStudentRequired: 3, arrivalTimes: [-1, -3, 1, 2])
angryProfessor00.resolve()
println(angryProfessor00.getResult())
