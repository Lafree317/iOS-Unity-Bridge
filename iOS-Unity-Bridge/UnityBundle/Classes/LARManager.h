//
//  LARManager.h
//  Unity-iPhone
//
//  Created by 胡春源 on 2019/8/23.
//

#import <Foundation/Foundation.h>

@interface LARManager : NSObject
/** 是否暂停Unity */
@property (assign, nonatomic) BOOL unityIsPaused;
+ (instancetype)sharedInstance;
@end
