#!/bin/bash

nuget install FAKE -Version 3.5.4
mono --runtime=v4.0 packages/FAKE.3.5.4/tools/Fake.exe build_mac.fsx $@