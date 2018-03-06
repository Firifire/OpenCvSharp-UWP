set(the_description "Custom Calibration Pattern")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(ccalib opencv_core opencv_imgproc opencv_calib3d opencv_features2d opencv_highgui WRAP python)
