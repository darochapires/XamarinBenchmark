//
//  AlgorithmPerformanceViewController.m
//  test2
//
//  Created by pedro on 09/06/15.
//  Copyright (c) 2015 RP. All rights reserved.
//

#import "AlgorithmPerformanceViewController.h"

@interface AlgorithmPerformanceViewController ()

@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciValue;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime1;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime2;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime3;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime4;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime5;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime6;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime7;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime8;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime9;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTime10;
@property (strong, nonatomic) IBOutlet UILabel *labelFibonacciTimeTotal;
@property (strong, nonatomic) IBOutlet UITextField *textFieldNumberOfIterations;
@property (strong, nonatomic) IBOutlet UIButton *buttonRun;
@property (strong, nonatomic) IBOutlet UIButton *buttonRunTenTimes;

@end

@implementation AlgorithmPerformanceViewController

- (void)viewDidLoad {
    [super viewDidLoad];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
}

- (IBAction)buttonRunTouched:(id)sender {
    
    int numberOfIterations = [self.textFieldNumberOfIterations.text isEqualToString:@""] ? 40 : [self.textFieldNumberOfIterations.text intValue];
    
    [self.textFieldNumberOfIterations setText:[NSString stringWithFormat:@"%d", numberOfIterations]];
    
    //running on UI thread
    [[NSOperationQueue mainQueue] addOperationWithBlock:^{
        NSTimeInterval start = [[NSDate date] timeIntervalSince1970];
        int result = [AlgorithmPerformanceViewController Fibonacci:numberOfIterations];
        NSTimeInterval end = [[NSDate date] timeIntervalSince1970];
        
        NSTimeInterval duration = end - start;
        NSLog(@"Fibonacci Value: %d, Duration: %f",result,duration);
        
        [self.labelFibonacciValue setText:[NSString stringWithFormat:@"%d",result]];
        [self.labelFibonacciTime1 setText:[NSString stringWithFormat:@"%f",duration]];
    }];
}

- (IBAction)buttonRunTenTimesTouched:(id)sender {
    
    int numberOfIterations = [self.textFieldNumberOfIterations.text isEqualToString:@""] ? 40 : [self.textFieldNumberOfIterations.text intValue];
    
    [self.textFieldNumberOfIterations setText:[NSString stringWithFormat:@"%d", numberOfIterations]];
    
    dispatch_async(dispatch_get_main_queue(), ^{
        
        NSTimeInterval totalTime = 0;
        for(int i = 0; i < 10; i++) {
        
            NSTimeInterval start = [[NSDate date] timeIntervalSince1970];
            int result = [AlgorithmPerformanceViewController Fibonacci:numberOfIterations];
            NSTimeInterval end = [[NSDate date] timeIntervalSince1970];
            
            NSTimeInterval duration = end - start;
            NSLog(@"Fibonacci Value: %d, Duration: %f",result,duration);
            totalTime += duration;
            
            switch (i) {
                case 0:
                    [self.labelFibonacciTime1 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 1:
                    [self.labelFibonacciTime2 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 2:
                    [self.labelFibonacciTime3 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 3:
                    [self.labelFibonacciTime4 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 4:
                    [self.labelFibonacciTime5 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 5:
                    [self.labelFibonacciTime6 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 6:
                    [self.labelFibonacciTime7 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 7:
                    [self.labelFibonacciTime8 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 8:
                    [self.labelFibonacciTime9 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                case 9:
                    [self.labelFibonacciTime10 setText:[NSString stringWithFormat:@"%f",duration]];
                    break;
                    
                default:
                    break;
            }
            [self.labelFibonacciTimeTotal setText:[NSString stringWithFormat:@"%f",totalTime/10]];
        }
    });
}

+ (int)Fibonacci:(int)num {
    if (num == 0) {
        return 0;
    }
    if (num == 1) {
        return 1;
    }
    return [self Fibonacci:num - 1] + [self Fibonacci:num - 2];
}

@end
