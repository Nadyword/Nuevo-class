import React from "react";

import { Card, Icon } from "@mui/material";
import VuiBox from "components/VuiBox";
import VuiTypography from "components/VuiTypography";

import gif from "assets/images/classroom-logo.png";

const WelcomeMark = () => {
    return (
        <Card sx={() => ({
            height: "320px",
            py: "32px",
            backgroundImage: `url(${gif})`,
            backgroundSize: "cover",
            backgroundPosition: "center"
        })}>

            <VuiBox height="100%" display="flex" flexDirection="column" justifyContent="space-between">
                <VuiBox>
                    <VuiTypography color="text" variant="button" fontWeight="regular" mb="12px">
                        Welcome back,
                    </VuiTypography>
                    <VuiTypography color="white" variant="h3" fontWeight="bold" mb="18px">
                        Adriana Cortes
                    </VuiTypography>
                    <VuiTypography color="text" variant="h6" fontWeight="regular" mb="auto">
                        Directora de desarrollo.
                    </VuiTypography>
                    <VuiTypography color="text" variant="h6" fontWeight="regular" mb="auto" display="flex" textAling="center" justifyContent="center" component="a"
                        href="#"
                        variant="button"
                        color="white"
                        fontWeight="regular"
                        sx={{
                            mr: "5px",
                            cursor: "pointer",

                            "& .material-icons-round": {
                                fontSize: "1.125rem",
                                transform: `translate(2px, -0.5px)`,
                                transition: "transform 0.2s cubic-bezier(0.34,1.61,0.7,1.3)",
                            },

                            "&:hover .material-icons-round, &:focus  .material-icons-round": {
                                transform: `translate(6px, -0.5px)`,
                            },
                        }}>
                        <br />
                        <br />
                        Hola este es un texto para probar el como se ve el texto en el componente
                    </VuiTypography>
                </VuiBox>
                <VuiTypography
                    component="a"
                    href="#"
                    variant="button"
                    color="white"
                    fontWeight="regular"
                    sx={{
                        mr: "5px",
                        display: "inline-flex",
                        alignItems: "center",
                        cursor: "pointer",

                        "& .material-icons-round": {
                            fontSize: "1.125rem",
                            transform: `translate(2px, -0.5px)`,
                            transition: "transform 0.2s cubic-bezier(0.34,1.61,0.7,1.3)",
                        },

                        "&:hover .material-icons-round, &:focus  .material-icons-round": {
                            transform: `translate(6px, -0.5px)`,
                        },
                    }}
                >
                    Tap to record
                    <Icon sx={{ fontWeight: "bold", ml: "5px" }}>arrow_forward</Icon>
                </VuiTypography>
            </VuiBox>
        </Card>
    );
};

export default WelcomeMark;
