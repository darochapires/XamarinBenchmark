//
//  ViewController.m
//  iOSNativeBlankApp
//
//  Created by Pedro da Rocha Pires on 09/03/16.
//  Copyright © 2016 Pedro da Rocha Pires. All rights reserved.
//

#import "ViewController.h"

extern NSTimeInterval startDate;

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
}

-(void)viewDidAppear:(BOOL)animated{
    NSTimeInterval endDate = [[NSDate date] timeIntervalSince1970];
    NSTimeInterval duration = endDate - startDate;
    
    NSString *message = [NSString stringWithFormat:@"%f miliseconds", duration];
    
    UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Elapsed Time" message:message delegate:nil cancelButtonTitle:@"OK" otherButtonTitles:nil];
    [alert show];
}

@end
