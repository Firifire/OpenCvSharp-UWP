set(the_description "Optical Flow Algorithms")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(optflow opencv_core opencv_imgproc opencv_video opencv_ximgproc opencv_imgcodecs WRAP python)
