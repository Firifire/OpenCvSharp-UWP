set(the_description "Camera Calibration and 3D Reconstruction")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(calib3d opencv_imgproc opencv_features2d WRAP java python)
