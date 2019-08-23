#import "LARManager.h"

@implementation LARManager

+ (instancetype)sharedInstance
{
    static LARManager *manager;
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        manager = [[self alloc] init];
    });
    return manager;
}

- (instancetype)init
{
    if (self = [super init]) {
        self.unityIsPaused = NO;
        NSLog(@"单例初始化成功");
    }
    return self;
}
@end
