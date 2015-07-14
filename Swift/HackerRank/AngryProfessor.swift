//
//  AngryProfessor.swift
//  HackerRank
//
//  Created by Bastien on 14/07/2015.
//  Copyright (c) 2015 Bastien. All rights reserved.
//

import Foundation

enum RESPONSE : String {
    case YES = "YES"
    case NO = "NO"
    
    func getValue() -> String { return self.rawValue }
}

class AngryProfessor : AlgorithmProtocol {
    
    var result: String
    let numberOfStudent : Int, minimumStudentRequired : Int
    let arrivalTimes : Array<Int>
    
    init(numberOfStudent : Int, minimumStudentRequired: Int, arrivalTimes : Array<Int>) {
        self.result = RESPONSE.YES.getValue()
        self.numberOfStudent = numberOfStudent
        self.minimumStudentRequired = minimumStudentRequired
        self.arrivalTimes = arrivalTimes
    }
    
    func resolve() {
        var count = 0
        for arrival in self.arrivalTimes {
            if (arrival <= 0) {
                count++
            }
        }
        self.result = count >= self.minimumStudentRequired ? RESPONSE.NO.getValue() : RESPONSE.YES.getValue()
    }
    
     func getResult() -> String {
        return self.result;
    }
}