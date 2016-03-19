//
//  main.m
//  iOSNativeBlankApp
//
//  Created by Pedro da Rocha Pires on 09/03/16.
//  Copyright © 2016 Pedro da Rocha Pires. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "AppDelegate.h"

NSTimeInterval startDate;

int main(int argc, char * argv[]) {
        
    startDate = [[NSDate date] timeIntervalSince1970];
    
    @autoreleasepool {
        return UIApplicationMain(argc, argv, nil, NSStringFromClass([AppDelegate class]));
    }
}
