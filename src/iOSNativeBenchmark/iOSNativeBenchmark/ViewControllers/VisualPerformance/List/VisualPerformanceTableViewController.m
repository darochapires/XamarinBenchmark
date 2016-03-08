//
//  VisualPerformanceTableViewController.m
//  test2
//
//  Created by pedro on 09/06/15.
//  Copyright (c) 2015 RP. All rights reserved.
//

#import "VisualPerformanceTableViewController.h"
#import "CellInfo.h"

@interface VisualPerformanceTableViewController ()

@end

@implementation VisualPerformanceTableViewController {
    NSMutableArray *cells;
}


- (void)viewDidLoad {
    [super viewDidLoad];
    
    // Uncomment the following line to preserve selection between presentations.
    // self.clearsSelectionOnViewWillAppear = NO;
    
    // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
    // self.navigationItem.rightBarButtonItem = self.editButtonItem;
    
    cells = [NSMutableArray arrayWithCapacity:1000];
    
    for (int i = 0; i < 1000; i++) {
        CellInfo *cell = [[CellInfo alloc] init];
        cell.textInfo = @"iOS Native Benchmark cell ";
        cell.image = [UIImage imageNamed:@"pic"];
        cells[i] = cell;
    }
}

#pragma mark - Table view data source

- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView {
    return 1;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
    return [cells count];
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:@"simpleCell"];
    
    CellInfo *info = cells[indexPath.row];
    cell.textLabel.text = info.textInfo;
    cell.imageView.image = info.image;
    
    return cell;
}

@end
