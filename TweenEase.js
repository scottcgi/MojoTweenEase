/*
 * The original algorithms of easing functions come from Robert Penner.
 * The open source licensed under the MIT License and the BSD License.
 *
 * Introduce: http://robertpenner.com/easing
 * License  : http://robertpenner.com/easing_terms_of_use.html
 *
 *----------------------------------------------------------------------------------------------------------------------
 * 
 * Copyright (c) scott.cgi All Rights Reserved.
 *
 * This source code belongs to project MojoTweenEase, which is hosted on GitHub, and licensed under the MIT License.
 *
 * License: https://github.com/scottcgi/MojoTweenEase/blob/master/LICENSE
 * GitHub : https://github.com/scottcgi/MojoTweenEase
 *
 * Since  : 2019-12-23
 * Author : scott.cgi
 * Version: 1.0.0
 */

var tweenEase = {

    linear: function(time) {
        return time;
    },


    quadraticIn: function(time) {
        return time * time;
    },
    quadraticOut: function(time) {
        return time * (2.0 - time);
    },
    quadraticInOut: function(time) {
        if (time < 0.5) {
            return time * time * 2.0;
        } 
            
        return 2.0 * time * (2.0 - time) - 1.0;
    },


    cubicIn: function(time) {
        return time * time * time;
    },
    cubicOut: function(time) {
        time -= 1.0;
        return time * time * time + 1.0;
    },
    cubicInOut: function(time) {
        if (time < 0.5) {
            return 4.0 * time * time * time;
        } 

        time -= 1.0;
        return 4.0 * time * time * time + 1.0;
    },


    quarticIn: function(time) {
        return time * time * time * time;
    },
    quarticOut: function(time) {
        time -= 1.0;
        return 1.0 - time * time * time * time;
    },
    quarticInOut: function(time) {
        if (time < 0.5) {
            return 8.0 * time * time * time * time;
        } 

        time -= 1.0;
        return 1.0 - 8.0 * time * time * time * time;
    },


    quinticIn: function(time) {
        return time * time * time * time * time;
    },
    quinticOut: function(time) {
        time -= 1.0;
        return time * time * time * time * time + 1.0;
    },
    quinticInOut: function(time) {
        if (time < 0.5) {
            return 16.0 * time * time * time * time * time;
        } 

        time -= 1.0;
        return 16.0 * time * time * time * time * time + 1.0;
    },      
    

    exponentialIn: function(time) {
        if (time <= 0.0) {
            return time;
        } 

        return Math.pow(2.0, 10.0 * (time - 1.0));
    },
    exponentialOut: function(time) {
        if (time >= 1.0) {
            return time;
        }

        return 1.0 - Math.pow(2.0, -10.0 * time);
    },
    exponentialInOut: function(time) {
        if (time <= 0.0 || time >= 1.0) {
            return time;
        }
    
        if (time < 0.5) {
            return 0.5 * Math.pow(2.0, 20.0 * time - 10.0);
        } 

        return 0.5 * (2.0 - Math.pow(2.0, -20.0 * time + 10.0));
    }, 


    sineIn: function(time) {
        return 1.0 - Math.cos(time * 1.570796326794897);
    },
    sineOut: function(time) {
        return Math.sin(time * 1.570796326794897);
    },
    sineInOut: function(time) {
        return 0.5 * (1.0 - Math.cos(time * 3.141592653589793));
    }, 


    circularIn: function(time) {
        return 1.0 - Math.sqrt(1.0 - time * time);
    },
    circularOut: function(time) {
        return Math.sqrt((2.0 - time) * time);
    },
    circularInOut: function(time) {
        if (time < 0.5) {
            return 0.5 * (1.0 - Math.sqrt(1.0 - 4.0 * time * time));
        }

        time = time * 2.0 - 2.0;
        return 0.5 * (Math.sqrt(1.0 - time * time) + 1.0);
    }, 


    elasticIn: function(time) {
        if (time <= 0.0 || time >= 1.0)
        {
            return time;
        }
    
        return -Math.pow(2.0, 10.0 * time - 10.0) * Math.sin(20.923007 * time - 22.493803);
    },
    elasticOut: function(time) {
        if (time <= 0.0 || time >= 1.0)
        {
            return time;
        }
    
        return Math.pow(2.0, -10.0 * time) * Math.sin(20.923007 * time - 1.570796) + 1.0;
    },
    elasticInOut: function(time) {
        if (time <= 0.0 || time >= 1.0) {
            return time;
        }
    
        if (time < 0.5) {
            return -0.5 * Math.pow(2.0, 20.0 * time - 10.0) * Math.sin(27.960175 * time - 15.550884);
        } 

        return Math.pow(2.0, -20.0 * time + 10.0) * Math.sin(27.960175 * time - 15.550884) * 0.5 + 1.0;
    }, 


    backIn: function(time) {
        return time * time * (2.70158 * time - 1.70158);
    },
    backOut: function(time) {
        time -= 1.0;
        return time * time * (2.70158 * time + 1.70158) + 1.0;
    },
    backInOut: function(time) {
        if (time < 0.5) {
            return time * time * (14.379636 * time - 5.189818);
        } 

        time -= 1.0;
        return time * time * (14.379636 * time + 5.189818) + 1.0;
    },
    backInExponentialOut: function(time) {
        if (time < 0.5) {
            return time * time * (14.379636 * time - 5.189818);
        } 

        return 0.5 * (2.0 - Math.pow(2.0, -20.0 * time + 10.0));
    },
    backInElasticOut: function(time) {
        if (time < 0.5) {
            return time * time * (14.379636 * time - 5.189818);
        } 

        return Math.pow(2.0, -20.0 * time + 10.0) * Math.sin(27.960175 * time - 15.550884) * 0.5 + 1.0;
    },


    bounceIn: function(time) {
        if (time > 0.636364) {
            time = 1.0 - time;
            return 1.0 - 7.5625 * time * time;
        } 

        if (time > 0.27273) {
            time = 0.454546 - time;
            return 0.25 - 7.5625 * time * time;
        } 

        if (time > 0.090909) {
            time = 0.181818 - time;
            return 0.0625 - 7.5625 * time * time;
        } 
        
        if (time >= 1.0) {
            return time;
        }

        time = 0.045455 - time;
        return 0.015625 - 7.5625 * time * time;
    },
    bounceOut: function(time) {
        if (time < 0.363636) {
            return 7.5625 * time * time;
        } 
        
        if (time < 0.72727) {
            time -= 0.545454;
            return 7.5625 * time * time + 0.75;
        } 
        
        if (time < 0.909091) {
            time -= 0.818182;
            return 7.5625 * time * time + 0.9375;
        } 
        
        if (time >= 1.0) {
            return time;
        }

        time -= 0.954545;
        return 7.5625 * time * time + 0.984375;
    },
    bounceInOut: function(time) {
        if (time < 0.5) {
            // bounce in
            if (time > 0.318182) {
                time = 1.0 - time * 2.0;
                return 0.5 - 3.78125 * time * time;
            } 
            
            if (time > 0.136365) {
                time = 0.454546 - time * 2.0;
                return 0.125 - 3.78125 * time * time;
            } 

            if (time > 0.045455) {
                time = 0.181818 - time * 2.0;
                return 0.03125 - 3.78125 * time * time;
            } 
            
            time = 0.045455 - time * 2.0;
            return 0.007813 - 3.78125 * time * time;
        } 

        // bounce out
        if (time < 0.681818) {
            time = time * 2.0 - 1.0;
            return 3.78125 * time * time + 0.5;
        } 
        
        if (time < 0.863635) {
            time = time * 2.0 - 1.545454;
            return 3.78125 * time * time + 0.875;
        } 
        
        if (time < 0.954546) {
            time = time * 2.0 - 1.818182;
            return 3.78125 * time * time + 0.96875;
        } 
        
        if (time >= 1.0) {
            return time;
        }

        time = time * 2.0 - 1.954545;
        return 3.78125 * time * time + 0.992188;
    },
};

