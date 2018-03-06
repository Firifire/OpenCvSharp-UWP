set(the_description "Stereo Correspondence")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(stereo opencv_imgproc opencv_features2d opencv_core opencv_calib3d)
