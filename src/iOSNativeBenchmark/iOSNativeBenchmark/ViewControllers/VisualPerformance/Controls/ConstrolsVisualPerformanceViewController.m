//
//  ConstrolsVisualPerformanceViewController.m
//  test2
//
//  Created by pedro on 07/02/16.
//  Copyright © 2016 RP. All rights reserved.
//

#import "ConstrolsVisualPerformanceViewController.h"

@interface ConstrolsVisualPerformanceViewController ()

@end

@implementation ConstrolsVisualPerformanceViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    for (int i = 0; i<1000; i++) {
        
        UIButton *button = [UIButton buttonWithType:UIButtonTypeCustom];
        button.frame = CGRectMake(260, 30, 50, 28);
        [button setTitleColor: [UIColor colorWithRed:19/255.0 green:144/255.0 blue:255/255.0 alpha:1.0] forState:UIControlStateNormal];
        
        [button setTitle:@"iOS Native Benchmark" forState:UIControlStateNormal];
        [self.view addSubview:button];
        button.translatesAutoresizingMaskIntoConstraints = NO;
        
        NSLayoutConstraint *width =[NSLayoutConstraint
                                    constraintWithItem:button
                                    attribute:NSLayoutAttributeWidth
                                    relatedBy:0
                                    toItem:self.view
                                    attribute:NSLayoutAttributeWidth
                                    multiplier:1.0
                                    constant:0];
        NSLayoutConstraint *height =[NSLayoutConstraint
                                     constraintWithItem:button
                                     attribute:NSLayoutAttributeHeight
                                     relatedBy:0
                                     toItem:self.view
                                     attribute:NSLayoutAttributeHeight
                                     multiplier:1.0
                                     constant:0];
        NSLayoutConstraint *top = [NSLayoutConstraint
                                   constraintWithItem:button
                                   attribute:NSLayoutAttributeTop
                                   relatedBy:NSLayoutRelationEqual
                                   toItem:self.view
                                   attribute:NSLayoutAttributeTop
                                   multiplier:1.0f
                                   constant:0.f];
        NSLayoutConstraint *leading = [NSLayoutConstraint
                                       constraintWithItem:button
                                       attribute:NSLayoutAttributeLeading
                                       relatedBy:NSLayoutRelationEqual
                                       toItem:self.view
                                       attribute:NSLayoutAttributeLeading
                                       multiplier:1.0f
                                       constant:0.f];
        
        [self.view addConstraints:@[width, height, top, leading]];
    }
}

@end
