#import <Foundation/Foundation.h>

void outputAppendString (char *str1, char *str2)
{
    NSString *string1 = [[NSString alloc] initWithUTF8String:str1];
    NSString *string2 = [[NSString alloc] initWithUTF8String:str2];
    
    NSLog(@"###%@", [NSString stringWithFormat:@"%@ %@", string1, string2]);
}
